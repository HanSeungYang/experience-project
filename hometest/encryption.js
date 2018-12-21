function detectEncryptionFeature() {
  if (typeof crypto == 'undefined' || !crypto.subtle || !crypto.subtle.digest ||
      !crypto.subtle.digest || !crypto.subtle.importKey ||
      !crypto.subtle.encrypt || !crypto.subtle.decrypt) {
    return Promise.reject('crypto.subtle is missing');
  }

  var algo = {name: 'AES-CBC', iv: new ArrayBuffer(16)};
  var key;
  return crypto.subtle
  .digest('SHA-256', new Uint8Array([30, 79, 12, 57]))
  .then(function(d){
    return crypto.subtle.importKey('raw', d, 'AES-CBC', false, ['encrypt', 'decrypt']);
  })
  .then(function(key1){
    key = key1;
    return crypto.subtle.encrypt(algo, key, new Uint8Array([12, 24, 15, 98]));
  })
  .then(function(ciphertext){
    return crypto.subtle.decrypt(algo, key, ciphertext);
  })
  .then(function(plaintext){
    var p = new Uint8Array(plaintext);
    if (p.length == 4 && p[0] == 12 && p[1] == 24 && p[2] == 15 && p[3] == 98) {
      return Promise.resolve(true);
    }
    else {
      return Promise.reject('encrypt-decrypt to wrong value');
    }
  });
}

// public: extract encryption key from URI, and prepare encryption object
// return a Promise of encryption object {algo: .., key: ..}
function prepareEncryption() {
  var m = location.hash.match(/#key=([^&]+)/);
  if (!m) {
    return Promise.resolve(false);
  }

  var password = m[1];
  var passwordBinary = new Uint8Array(password.length);
  for (var i = 0; i < password.length; ++i) {
    passwordBinary[i] = password.charCodeAt(i) % 256;
  }

  return crypto.subtle
  .digest('SHA-256', passwordBinary)
  .then(function(passwordDigest){
    return crypto.subtle.importKey('raw', passwordDigest, 'AES-CBC', false, ['encrypt', 'decrypt']);
  })
  .then(function(key) {
    return Promise.resolve({
      algo: {name: 'AES-CBC', iv: new ArrayBuffer(16)},
      key: key
    });
  });
}