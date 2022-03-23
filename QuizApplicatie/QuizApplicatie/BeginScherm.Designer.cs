
namespace QuizApplicatie
{
    partial class Form1
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
            System.Windows.Forms.Button QuickplayBtn;
            System.Windows.Forms.Button CustomQuizBtn;
            System.Windows.Forms.Button VragenbeheerBtn;
            System.Windows.Forms.Button ScoresBtn;
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            QuickplayBtn = new System.Windows.Forms.Button();
            CustomQuizBtn = new System.Windows.Forms.Button();
            VragenbeheerBtn = new System.Windows.Forms.Button();
            ScoresBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuickplayBtn
            // 
            QuickplayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            QuickplayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            QuickplayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            QuickplayBtn.FlatAppearance.BorderSize = 0;
            QuickplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            QuickplayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QuickplayBtn.ForeColor = System.Drawing.Color.White;
            QuickplayBtn.Location = new System.Drawing.Point(43, 22);
            QuickplayBtn.Margin = new System.Windows.Forms.Padding(2);
            QuickplayBtn.Name = "QuickplayBtn";
            QuickplayBtn.Size = new System.Drawing.Size(484, 138);
            QuickplayBtn.TabIndex = 0;
            QuickplayBtn.TabStop = false;
            QuickplayBtn.Text = "Quickplay";
            QuickplayBtn.UseVisualStyleBackColor = false;
            QuickplayBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomQuizBtn
            // 
            CustomQuizBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            CustomQuizBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            CustomQuizBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            CustomQuizBtn.FlatAppearance.BorderSize = 0;
            CustomQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CustomQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CustomQuizBtn.ForeColor = System.Drawing.Color.White;
            CustomQuizBtn.Location = new System.Drawing.Point(43, 172);
            CustomQuizBtn.Margin = new System.Windows.Forms.Padding(2);
            CustomQuizBtn.Name = "CustomQuizBtn";
            CustomQuizBtn.Size = new System.Drawing.Size(484, 138);
            CustomQuizBtn.TabIndex = 2;
            CustomQuizBtn.TabStop = false;
            CustomQuizBtn.Text = "Custom quiz";
            CustomQuizBtn.UseVisualStyleBackColor = false;
            CustomQuizBtn.Click += new System.EventHandler(this.CustomQuizBtn_Click);
            // 
            // VragenbeheerBtn
            // 
            VragenbeheerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            VragenbeheerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            VragenbeheerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            VragenbeheerBtn.FlatAppearance.BorderSize = 0;
            VragenbeheerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            VragenbeheerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            VragenbeheerBtn.ForeColor = System.Drawing.Color.White;
            VragenbeheerBtn.Location = new System.Drawing.Point(43, 321);
            VragenbeheerBtn.Margin = new System.Windows.Forms.Padding(2);
            VragenbeheerBtn.Name = "VragenbeheerBtn";
            VragenbeheerBtn.Size = new System.Drawing.Size(484, 138);
            VragenbeheerBtn.TabIndex = 3;
            VragenbeheerBtn.TabStop = false;
            VragenbeheerBtn.Text = "Vragenbeheer";
            VragenbeheerBtn.UseVisualStyleBackColor = false;
            VragenbeheerBtn.Click += new System.EventHandler(this.VragenbeheerBtn_Click);
            // 
            // ScoresBtn
            // 
            ScoresBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            ScoresBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            ScoresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ScoresBtn.FlatAppearance.BorderSize = 0;
            ScoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ScoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ScoresBtn.ForeColor = System.Drawing.Color.White;
            ScoresBtn.Location = new System.Drawing.Point(43, 470);
            ScoresBtn.Margin = new System.Windows.Forms.Padding(2);
            ScoresBtn.Name = "ScoresBtn";
            ScoresBtn.Size = new System.Drawing.Size(484, 138);
            ScoresBtn.TabIndex = 4;
            ScoresBtn.TabStop = false;
            ScoresBtn.Text = "Scores";
            ScoresBtn.UseVisualStyleBackColor = false;
            ScoresBtn.Click += new System.EventHandler(this.ScoresBtn_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(13, 12);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(603, 70);
            this.Title.TabIndex = 1;
            this.Title.Text = "Quiz applicatie";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(QuickplayBtn);
            this.panel1.Controls.Add(ScoresBtn);
            this.panel1.Controls.Add(CustomQuizBtn);
            this.panel1.Controls.Add(VragenbeheerBtn);
            this.panel1.Location = new System.Drawing.Point(20, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 627);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(628, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
    }
}

