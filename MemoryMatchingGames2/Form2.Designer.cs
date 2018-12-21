namespace MemoryMatchingGames2
{
    partial class GameWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CardsHolders = new System.Windows.Forms.Panel();
            this.DupCard6 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.DupCard5 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.DupCard4 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.DupCard3 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.DupCard2 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.DupCard1 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TimerCounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.CardsHolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsHolders
            // 
            this.CardsHolders.BackColor = System.Drawing.Color.Transparent;
            this.CardsHolders.Controls.Add(this.DupCard6);
            this.CardsHolders.Controls.Add(this.Card6);
            this.CardsHolders.Controls.Add(this.DupCard5);
            this.CardsHolders.Controls.Add(this.Card5);
            this.CardsHolders.Controls.Add(this.DupCard4);
            this.CardsHolders.Controls.Add(this.Card4);
            this.CardsHolders.Controls.Add(this.DupCard3);
            this.CardsHolders.Controls.Add(this.Card3);
            this.CardsHolders.Controls.Add(this.DupCard2);
            this.CardsHolders.Controls.Add(this.Card2);
            this.CardsHolders.Controls.Add(this.DupCard1);
            this.CardsHolders.Controls.Add(this.Card1);
            this.CardsHolders.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CardsHolders.Location = new System.Drawing.Point(12, 5);
            this.CardsHolders.Name = "CardsHolders";
            this.CardsHolders.Size = new System.Drawing.Size(501, 529);
            this.CardsHolders.TabIndex = 0;
            // 
            // DupCard6
            // 
            this.DupCard6.Location = new System.Drawing.Point(376, 360);
            this.DupCard6.Name = "DupCard6";
            this.DupCard6.Size = new System.Drawing.Size(100, 150);
            this.DupCard6.TabIndex = 11;
            this.DupCard6.TabStop = false;
            this.DupCard6.Tag = "6";
            this.DupCard6.Click += new System.EventHandler(this.DupCard6_Click);
            // 
            // Card6
            // 
            this.Card6.Location = new System.Drawing.Point(248, 360);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(100, 150);
            this.Card6.TabIndex = 10;
            this.Card6.TabStop = false;
            this.Card6.Tag = "6";
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // DupCard5
            // 
            this.DupCard5.Location = new System.Drawing.Point(128, 360);
            this.DupCard5.Name = "DupCard5";
            this.DupCard5.Size = new System.Drawing.Size(100, 150);
            this.DupCard5.TabIndex = 9;
            this.DupCard5.TabStop = false;
            this.DupCard5.Tag = "5";
            this.DupCard5.Click += new System.EventHandler(this.DupCard5_Click);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(12, 360);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(100, 150);
            this.Card5.TabIndex = 8;
            this.Card5.TabStop = false;
            this.Card5.Tag = "5";
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // DupCard4
            // 
            this.DupCard4.Location = new System.Drawing.Point(376, 187);
            this.DupCard4.Name = "DupCard4";
            this.DupCard4.Size = new System.Drawing.Size(100, 150);
            this.DupCard4.TabIndex = 7;
            this.DupCard4.TabStop = false;
            this.DupCard4.Tag = "4";
            this.DupCard4.Click += new System.EventHandler(this.DupCard4_Click);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(248, 187);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(100, 150);
            this.Card4.TabIndex = 6;
            this.Card4.TabStop = false;
            this.Card4.Tag = "4";
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // DupCard3
            // 
            this.DupCard3.Location = new System.Drawing.Point(128, 187);
            this.DupCard3.Name = "DupCard3";
            this.DupCard3.Size = new System.Drawing.Size(100, 150);
            this.DupCard3.TabIndex = 5;
            this.DupCard3.TabStop = false;
            this.DupCard3.Tag = "3";
            this.DupCard3.Click += new System.EventHandler(this.DupCard3_Click);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(12, 187);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(100, 150);
            this.Card3.TabIndex = 4;
            this.Card3.TabStop = false;
            this.Card3.Tag = "3";
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // DupCard2
            // 
            this.DupCard2.Location = new System.Drawing.Point(376, 7);
            this.DupCard2.Name = "DupCard2";
            this.DupCard2.Size = new System.Drawing.Size(100, 150);
            this.DupCard2.TabIndex = 3;
            this.DupCard2.TabStop = false;
            this.DupCard2.Tag = "2";
            this.DupCard2.Click += new System.EventHandler(this.DupCard2_Click);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(248, 7);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(100, 150);
            this.Card2.TabIndex = 2;
            this.Card2.TabStop = false;
            this.Card2.Tag = "2";
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // DupCard1
            // 
            this.DupCard1.Location = new System.Drawing.Point(127, 7);
            this.DupCard1.Name = "DupCard1";
            this.DupCard1.Size = new System.Drawing.Size(100, 150);
            this.DupCard1.TabIndex = 1;
            this.DupCard1.TabStop = false;
            this.DupCard1.Tag = "1";
            this.DupCard1.Click += new System.EventHandler(this.DupCard1_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(12, 7);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(100, 150);
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Tag = "1";
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Headline R", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreLabel.Location = new System.Drawing.Point(552, 5);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(99, 19);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score :";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Headline R", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreCounter.Location = new System.Drawing.Point(657, 5);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(24, 19);
            this.ScoreCounter.TabIndex = 2;
            this.ScoreCounter.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Headline R", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(657, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TimerCounter
            // 
            this.TimerCounter.AutoSize = true;
            this.TimerCounter.Font = new System.Drawing.Font("Headline R", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimerCounter.Location = new System.Drawing.Point(552, 42);
            this.TimerCounter.Name = "TimerCounter";
            this.TimerCounter.Size = new System.Drawing.Size(99, 19);
            this.TimerCounter.TabIndex = 4;
            this.TimerCounter.Text = "Timer :";
            this.TimerCounter.Click += new System.EventHandler(this.TimerCounter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(544, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 87);
            this.button1.TabIndex = 12;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(738, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimerCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CardsHolders);
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Matching";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.CardsHolders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CardsHolders;
        private System.Windows.Forms.PictureBox DupCard6;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox DupCard5;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox DupCard4;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox DupCard3;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox DupCard2;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox DupCard1;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label TimerCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer3;
    }
}

