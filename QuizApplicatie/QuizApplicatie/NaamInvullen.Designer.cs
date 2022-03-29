
namespace QuizApplicatie
{
    partial class NaamInvullen
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
            this.StartQuiz = new System.Windows.Forms.Button();
            this.NaamVeld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartQuiz
            // 
            this.StartQuiz.Location = new System.Drawing.Point(12, 56);
            this.StartQuiz.Name = "StartQuiz";
            this.StartQuiz.Size = new System.Drawing.Size(75, 23);
            this.StartQuiz.TabIndex = 0;
            this.StartQuiz.Text = "Start Quiz";
            this.StartQuiz.UseVisualStyleBackColor = true;
            this.StartQuiz.Click += new System.EventHandler(this.StartQuiz_Click);
            // 
            // NaamVeld
            // 
            this.NaamVeld.Location = new System.Drawing.Point(12, 30);
            this.NaamVeld.Name = "NaamVeld";
            this.NaamVeld.Size = new System.Drawing.Size(100, 20);
            this.NaamVeld.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vul uw naam in:";
            // 
            // NaamInvullen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 86);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NaamVeld);
            this.Controls.Add(this.StartQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NaamInvullen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NaamInvullen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartQuiz;
        private System.Windows.Forms.TextBox NaamVeld;
        private System.Windows.Forms.Label label1;
    }
}