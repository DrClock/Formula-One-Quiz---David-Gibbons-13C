namespace Formula_One_Quiz
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.CoverLabel1 = new System.Windows.Forms.Label();
            this.CoverLabel2 = new System.Windows.Forms.Label();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UpdateScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.QuestionLabel1 = new System.Windows.Forms.Label();
            this.QuestionLabel2 = new System.Windows.Forms.Label();
            this.LeftAnswer1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DownAnswer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RightAnswer1 = new System.Windows.Forms.Label();
            this.UpAnswer1 = new System.Windows.Forms.Label();
            this.UpAnswer2 = new System.Windows.Forms.Label();
            this.RightAnswer2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DownAnswer2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LeftAnswer2 = new System.Windows.Forms.Label();
            this.Track1 = new System.Windows.Forms.PictureBox();
            this.Track2 = new System.Windows.Forms.PictureBox();
            this.EndWaitTimer = new System.Windows.Forms.Timer(this.components);
            this.WheelBox1 = new System.Windows.Forms.PictureBox();
            this.WheelBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Track1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WheelBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WheelBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CoverLabel1
            // 
            this.CoverLabel1.BackColor = System.Drawing.Color.Black;
            this.CoverLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoverLabel1.ForeColor = System.Drawing.Color.White;
            this.CoverLabel1.Location = new System.Drawing.Point(0, 0);
            this.CoverLabel1.Name = "CoverLabel1";
            this.CoverLabel1.Size = new System.Drawing.Size(655, 165);
            this.CoverLabel1.TabIndex = 2;
            this.CoverLabel1.Text = "3";
            this.CoverLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoverLabel2
            // 
            this.CoverLabel2.BackColor = System.Drawing.Color.Black;
            this.CoverLabel2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoverLabel2.ForeColor = System.Drawing.Color.White;
            this.CoverLabel2.Location = new System.Drawing.Point(0, 360);
            this.CoverLabel2.Name = "CoverLabel2";
            this.CoverLabel2.Size = new System.Drawing.Size(655, 165);
            this.CoverLabel2.TabIndex = 3;
            this.CoverLabel2.Text = "3";
            this.CoverLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Enabled = true;
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(291, 252);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(72, 16);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "00:00:000";
            // 
            // UpdateScreenTimer
            // 
            this.UpdateScreenTimer.Interval = 50;
            this.UpdateScreenTimer.Tick += new System.EventHandler(this.UpdateScreenTimer_Tick);
            // 
            // QuestionLabel1
            // 
            this.QuestionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel1.Location = new System.Drawing.Point(166, 9);
            this.QuestionLabel1.Name = "QuestionLabel1";
            this.QuestionLabel1.Size = new System.Drawing.Size(322, 50);
            this.QuestionLabel1.TabIndex = 5;
            this.QuestionLabel1.Text = "In 1970, a driver was killed during a practice, yet still won the championship 2 " +
    "rounds later. Who was this?";
            this.QuestionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionLabel2
            // 
            this.QuestionLabel2.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel2.Location = new System.Drawing.Point(166, 371);
            this.QuestionLabel2.Name = "QuestionLabel2";
            this.QuestionLabel2.Size = new System.Drawing.Size(322, 50);
            this.QuestionLabel2.TabIndex = 6;
            this.QuestionLabel2.Text = "In 1970, a driver was killed during a practice, yet still won the championship 2 " +
    "rounds later. Who was this?";
            this.QuestionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftAnswer1
            // 
            this.LeftAnswer1.Location = new System.Drawing.Point(112, 97);
            this.LeftAnswer1.Name = "LeftAnswer1";
            this.LeftAnswer1.Size = new System.Drawing.Size(167, 21);
            this.LeftAnswer1.TabIndex = 7;
            this.LeftAnswer1.Text = "LeftAnswer(P1)";
            this.LeftAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "W";
            // 
            // DownAnswer1
            // 
            this.DownAnswer1.Location = new System.Drawing.Point(215, 132);
            this.DownAnswer1.Name = "DownAnswer1";
            this.DownAnswer1.Size = new System.Drawing.Size(222, 21);
            this.DownAnswer1.TabIndex = 9;
            this.DownAnswer1.Text = "DownAnswer(P1)";
            this.DownAnswer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "S";
            // 
            // RightAnswer1
            // 
            this.RightAnswer1.Location = new System.Drawing.Point(371, 97);
            this.RightAnswer1.Name = "RightAnswer1";
            this.RightAnswer1.Size = new System.Drawing.Size(162, 21);
            this.RightAnswer1.TabIndex = 14;
            this.RightAnswer1.Text = "RightAnswer(P1)";
            this.RightAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpAnswer1
            // 
            this.UpAnswer1.Location = new System.Drawing.Point(215, 65);
            this.UpAnswer1.Name = "UpAnswer1";
            this.UpAnswer1.Size = new System.Drawing.Size(222, 21);
            this.UpAnswer1.TabIndex = 15;
            this.UpAnswer1.Text = "UpAnswer(P1)";
            this.UpAnswer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UpAnswer2
            // 
            this.UpAnswer2.Location = new System.Drawing.Point(215, 428);
            this.UpAnswer2.Name = "UpAnswer2";
            this.UpAnswer2.Size = new System.Drawing.Size(222, 21);
            this.UpAnswer2.TabIndex = 23;
            this.UpAnswer2.Text = "UpAnswer(P2)";
            this.UpAnswer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RightAnswer2
            // 
            this.RightAnswer2.Location = new System.Drawing.Point(380, 460);
            this.RightAnswer2.Name = "RightAnswer2";
            this.RightAnswer2.Size = new System.Drawing.Size(162, 21);
            this.RightAnswer2.TabIndex = 22;
            this.RightAnswer2.Text = "RightAnswer(P2)";
            this.RightAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Down";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Left";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(341, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Right";
            // 
            // DownAnswer2
            // 
            this.DownAnswer2.Location = new System.Drawing.Point(215, 495);
            this.DownAnswer2.Name = "DownAnswer2";
            this.DownAnswer2.Size = new System.Drawing.Size(222, 21);
            this.DownAnswer2.TabIndex = 18;
            this.DownAnswer2.Text = "DownAnswer(P2)";
            this.DownAnswer2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(317, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Up";
            // 
            // LeftAnswer2
            // 
            this.LeftAnswer2.Location = new System.Drawing.Point(114, 460);
            this.LeftAnswer2.Name = "LeftAnswer2";
            this.LeftAnswer2.Size = new System.Drawing.Size(167, 21);
            this.LeftAnswer2.TabIndex = 16;
            this.LeftAnswer2.Text = "LeftAnswer(P2)";
            this.LeftAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Track1
            // 
            this.Track1.BackColor = System.Drawing.Color.Gray;
            this.Track1.Location = new System.Drawing.Point(66, 183);
            this.Track1.Name = "Track1";
            this.Track1.Size = new System.Drawing.Size(580, 56);
            this.Track1.TabIndex = 24;
            this.Track1.TabStop = false;
            // 
            // Track2
            // 
            this.Track2.BackColor = System.Drawing.Color.Gray;
            this.Track2.Location = new System.Drawing.Point(66, 278);
            this.Track2.Name = "Track2";
            this.Track2.Size = new System.Drawing.Size(580, 56);
            this.Track2.TabIndex = 25;
            this.Track2.TabStop = false;
            // 
            // EndWaitTimer
            // 
            this.EndWaitTimer.Interval = 1000;
            this.EndWaitTimer.Tick += new System.EventHandler(this.EndWaitTimer_Tick);
            // 
            // WheelBox1
            // 
            this.WheelBox1.Location = new System.Drawing.Point(4, 183);
            this.WheelBox1.Name = "WheelBox1";
            this.WheelBox1.Size = new System.Drawing.Size(56, 56);
            this.WheelBox1.TabIndex = 26;
            this.WheelBox1.TabStop = false;
            // 
            // WheelBox2
            // 
            this.WheelBox2.Location = new System.Drawing.Point(4, 278);
            this.WheelBox2.Name = "WheelBox2";
            this.WheelBox2.Size = new System.Drawing.Size(56, 56);
            this.WheelBox2.TabIndex = 27;
            this.WheelBox2.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(655, 525);
            this.Controls.Add(this.WheelBox2);
            this.Controls.Add(this.WheelBox1);
            this.Controls.Add(this.Track2);
            this.Controls.Add(this.Track1);
            this.Controls.Add(this.CoverLabel1);
            this.Controls.Add(this.CoverLabel2);
            this.Controls.Add(this.UpAnswer2);
            this.Controls.Add(this.RightAnswer2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DownAnswer2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LeftAnswer2);
            this.Controls.Add(this.UpAnswer1);
            this.Controls.Add(this.RightAnswer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DownAnswer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftAnswer1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.QuestionLabel1);
            this.Controls.Add(this.QuestionLabel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F1 FRENZY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameScreen_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Track1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WheelBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WheelBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoverLabel1;
        private System.Windows.Forms.Label CoverLabel2;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer UpdateScreenTimer;
        private System.Windows.Forms.Label QuestionLabel1;
        private System.Windows.Forms.Label QuestionLabel2;
        private System.Windows.Forms.Label LeftAnswer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DownAnswer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RightAnswer1;
        private System.Windows.Forms.Label UpAnswer1;
        private System.Windows.Forms.Label UpAnswer2;
        private System.Windows.Forms.Label RightAnswer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DownAnswer2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LeftAnswer2;
        private System.Windows.Forms.PictureBox Track1;
        private System.Windows.Forms.PictureBox Track2;
        private System.Windows.Forms.Timer EndWaitTimer;
        private System.Windows.Forms.PictureBox WheelBox1;
        private System.Windows.Forms.PictureBox WheelBox2;

    }
}