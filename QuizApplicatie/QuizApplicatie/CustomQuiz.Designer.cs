
namespace QuizApplicatie
{
    partial class CustomQuiz
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
            this.CustomQuizLabel = new System.Windows.Forms.Label();
            this.TijdPerVraag = new System.Windows.Forms.Label();
            this.Strafseconden = new System.Windows.Forms.Label();
            this.AantalVragen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomQuizLabel
            // 
            this.CustomQuizLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.CustomQuizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.CustomQuizLabel.ForeColor = System.Drawing.Color.White;
            this.CustomQuizLabel.Location = new System.Drawing.Point(53, 33);
            this.CustomQuizLabel.Name = "CustomQuizLabel";
            this.CustomQuizLabel.Size = new System.Drawing.Size(1813, 119);
            this.CustomQuizLabel.TabIndex = 0;
            this.CustomQuizLabel.Text = "Custom quiz";
            this.CustomQuizLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TijdPerVraag
            // 
            this.TijdPerVraag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.TijdPerVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.TijdPerVraag.ForeColor = System.Drawing.Color.White;
            this.TijdPerVraag.Location = new System.Drawing.Point(101, 287);
            this.TijdPerVraag.Name = "TijdPerVraag";
            this.TijdPerVraag.Size = new System.Drawing.Size(510, 150);
            this.TijdPerVraag.TabIndex = 1;
            this.TijdPerVraag.Text = "Tijd per vraag";
            this.TijdPerVraag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Strafseconden
            // 
            this.Strafseconden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.Strafseconden.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.Strafseconden.ForeColor = System.Drawing.Color.White;
            this.Strafseconden.Location = new System.Drawing.Point(101, 475);
            this.Strafseconden.Name = "Strafseconden";
            this.Strafseconden.Size = new System.Drawing.Size(510, 150);
            this.Strafseconden.TabIndex = 2;
            this.Strafseconden.Text = "Strafseconden";
            this.Strafseconden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AantalVragen
            // 
            this.AantalVragen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.AantalVragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.AantalVragen.ForeColor = System.Drawing.Color.White;
            this.AantalVragen.Location = new System.Drawing.Point(101, 658);
            this.AantalVragen.Name = "AantalVragen";
            this.AantalVragen.Size = new System.Drawing.Size(510, 150);
            this.AantalVragen.TabIndex = 3;
            this.AantalVragen.Text = "Aantal vragen";
            this.AantalVragen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.AantalVragen);
            this.Controls.Add(this.Strafseconden);
            this.Controls.Add(this.TijdPerVraag);
            this.Controls.Add(this.CustomQuizLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomQuiz";
            this.Text = "Custom quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomQuizLabel;
        private System.Windows.Forms.Label TijdPerVraag;
        private System.Windows.Forms.Label Strafseconden;
        private System.Windows.Forms.Label AantalVragen;
    }
}