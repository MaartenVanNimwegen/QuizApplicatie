
namespace QuizApplicatie
{
    partial class NaamInvullenCustom
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
            this.label1 = new System.Windows.Forms.Label();
            this.NaamVeldCustom = new System.Windows.Forms.TextBox();
            this.StartQuizCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vul uw naam in:";
            // 
            // NaamVeldCustom
            // 
            this.NaamVeldCustom.Location = new System.Drawing.Point(12, 24);
            this.NaamVeldCustom.Name = "NaamVeldCustom";
            this.NaamVeldCustom.Size = new System.Drawing.Size(100, 20);
            this.NaamVeldCustom.TabIndex = 4;
            // 
            // StartQuizCustom
            // 
            this.StartQuizCustom.Location = new System.Drawing.Point(12, 50);
            this.StartQuizCustom.Name = "StartQuizCustom";
            this.StartQuizCustom.Size = new System.Drawing.Size(75, 23);
            this.StartQuizCustom.TabIndex = 3;
            this.StartQuizCustom.Text = "Start Quiz";
            this.StartQuizCustom.UseVisualStyleBackColor = true;
            this.StartQuizCustom.Click += new System.EventHandler(this.StartQuizCustom_Click);
            // 
            // NaamInvullenCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 84);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NaamVeldCustom);
            this.Controls.Add(this.StartQuizCustom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NaamInvullenCustom";
            this.Text = "NaamInvullenCustom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NaamVeldCustom;
        private System.Windows.Forms.Button StartQuizCustom;
    }
}