
namespace QuizApplicatie
{
    partial class VragenScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VragenScherm));
            this.VraagLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExtraSecondsLabel = new System.Windows.Forms.Label();
            this.GlobalTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuestionTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectedB = new System.Windows.Forms.Label();
            this.SelectedA = new System.Windows.Forms.Label();
            this.AnswerB = new System.Windows.Forms.Label();
            this.BLetter = new System.Windows.Forms.Label();
            this.AnswerA = new System.Windows.Forms.Label();
            this.ALetter = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.GlobalCountUpTimer = new System.Windows.Forms.Timer(this.components);
            this.TijdVanAntwoorden = new System.Windows.Forms.Timer(this.components);
            this.AftelTimerVolgendeVraag = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // VraagLable
            // 
            this.VraagLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VraagLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VraagLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraagLable.ForeColor = System.Drawing.SystemColors.Control;
            this.VraagLable.Location = new System.Drawing.Point(57, 28);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1847, 119);
            this.VraagLable.TabIndex = 0;
            this.VraagLable.Text = "Vraag";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.ExtraSecondsLabel);
            this.panel1.Controls.Add(this.GlobalTimeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.QuestionTimeLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1583, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 861);
            this.panel1.TabIndex = 4;
            // 
            // ExtraSecondsLabel
            // 
            this.ExtraSecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExtraSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraSecondsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ExtraSecondsLabel.Location = new System.Drawing.Point(234, 138);
            this.ExtraSecondsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExtraSecondsLabel.Name = "ExtraSecondsLabel";
            this.ExtraSecondsLabel.Size = new System.Drawing.Size(86, 67);
            this.ExtraSecondsLabel.TabIndex = 3;
            this.ExtraSecondsLabel.Text = "0";
            this.ExtraSecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GlobalTimeLabel
            // 
            this.GlobalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GlobalTimeLabel.Location = new System.Drawing.Point(227, 72);
            this.GlobalTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GlobalTimeLabel.Name = "GlobalTimeLabel";
            this.GlobalTimeLabel.Size = new System.Drawing.Size(94, 67);
            this.GlobalTimeLabel.TabIndex = 7;
            this.GlobalTimeLabel.Text = "0";
            this.GlobalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 67);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gebruikte tijd:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 67);
            this.label4.TabIndex = 2;
            this.label4.Text = "Strafseconden:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionTimeLabel
            // 
            this.QuestionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.QuestionTimeLabel.Location = new System.Drawing.Point(204, 5);
            this.QuestionTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionTimeLabel.Name = "QuestionTimeLabel";
            this.QuestionTimeLabel.Size = new System.Drawing.Size(120, 67);
            this.QuestionTimeLabel.TabIndex = 1;
            this.QuestionTimeLabel.Text = "0";
            this.QuestionTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 67);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tijd voor deze vraag:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.panel2.Controls.Add(this.SelectedB);
            this.panel2.Controls.Add(this.SelectedA);
            this.panel2.Controls.Add(this.AnswerB);
            this.panel2.Controls.Add(this.BLetter);
            this.panel2.Controls.Add(this.AnswerA);
            this.panel2.Controls.Add(this.ALetter);
            this.panel2.Location = new System.Drawing.Point(57, 182);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1508, 861);
            this.panel2.TabIndex = 5;
            // 
            // SelectedB
            // 
            this.SelectedB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.SelectedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedB.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectedB.Location = new System.Drawing.Point(40, 519);
            this.SelectedB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedB.Name = "SelectedB";
            this.SelectedB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedB.Size = new System.Drawing.Size(10, 247);
            this.SelectedB.TabIndex = 12;
            this.SelectedB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedA
            // 
            this.SelectedA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.SelectedA.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedA.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectedA.Location = new System.Drawing.Point(40, 120);
            this.SelectedA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedA.Name = "SelectedA";
            this.SelectedA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedA.Size = new System.Drawing.Size(10, 247);
            this.SelectedA.TabIndex = 11;
            this.SelectedA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerB
            // 
            this.AnswerB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.AnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerB.ForeColor = System.Drawing.SystemColors.Control;
            this.AnswerB.Location = new System.Drawing.Point(275, 592);
            this.AnswerB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnswerB.Size = new System.Drawing.Size(1141, 150);
            this.AnswerB.TabIndex = 10;
            this.AnswerB.Text = "Antwoord B";
            this.AnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BLetter
            // 
            this.BLetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.BLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLetter.ForeColor = System.Drawing.SystemColors.Control;
            this.BLetter.Location = new System.Drawing.Point(40, 519);
            this.BLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BLetter.Name = "BLetter";
            this.BLetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BLetter.Size = new System.Drawing.Size(264, 247);
            this.BLetter.TabIndex = 9;
            this.BLetter.Text = "B";
            this.BLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerA
            // 
            this.AnswerA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.AnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerA.ForeColor = System.Drawing.Color.White;
            this.AnswerA.Location = new System.Drawing.Point(293, 178);
            this.AnswerA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnswerA.Size = new System.Drawing.Size(1141, 150);
            this.AnswerA.TabIndex = 8;
            this.AnswerA.Text = "Antwoord A";
            this.AnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ALetter
            // 
            this.ALetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ALetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.ALetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALetter.ForeColor = System.Drawing.SystemColors.Control;
            this.ALetter.Location = new System.Drawing.Point(40, 120);
            this.ALetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ALetter.Name = "ALetter";
            this.ALetter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALetter.Size = new System.Drawing.Size(264, 247);
            this.ALetter.TabIndex = 7;
            this.ALetter.Text = "A";
            this.ALetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(79, 66);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(41, 41);
            this.BackBtn.TabIndex = 66;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // GlobalCountUpTimer
            // 
            this.GlobalCountUpTimer.Enabled = true;
            this.GlobalCountUpTimer.Interval = 1000;
            this.GlobalCountUpTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // TijdVanAntwoorden
            // 
            this.TijdVanAntwoorden.Enabled = true;
            this.TijdVanAntwoorden.Interval = 1000;
            this.TijdVanAntwoorden.Tick += new System.EventHandler(this.TijdVanAntwoorden_Tick);
            // 
            // AftelTimerVolgendeVraag
            // 
            this.AftelTimerVolgendeVraag.Enabled = true;
            this.AftelTimerVolgendeVraag.Interval = 1000;
            this.AftelTimerVolgendeVraag.Tick += new System.EventHandler(this.AftelTimerVolgendeVraag_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.Yellow;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Location = new System.Drawing.Point(57, 137);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1846, 10);
            this.progressBar.TabIndex = 13;
            // 
            // VragenScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VraagLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VragenScherm";
            this.Text = "vragenscherm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VragenScherm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label QuestionTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AnswerA;
        private System.Windows.Forms.Label ALetter;
        private System.Windows.Forms.Label AnswerB;
        private System.Windows.Forms.Label BLetter;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Timer GlobalCountUpTimer;
        private System.Windows.Forms.Label GlobalTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TijdVanAntwoorden;
        private System.Windows.Forms.Timer AftelTimerVolgendeVraag;
        private System.Windows.Forms.Label SelectedB;
        private System.Windows.Forms.Label SelectedA;
        private System.Windows.Forms.Label ExtraSecondsLabel;
        public System.Windows.Forms.ProgressBar progressBar;
    }
}