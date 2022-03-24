
namespace QuizApplicatie
{
    partial class scores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scores));
            this.VraagLable = new System.Windows.Forms.Label();
            this.AntwoordGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotaleTijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gebruiktetijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.straftijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumentijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AntwoordGrid)).BeginInit();
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
            this.VraagLable.Location = new System.Drawing.Point(11, 9);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1882, 119);
            this.VraagLable.TabIndex = 9;
            this.VraagLable.Text = "Scores";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AntwoordGrid
            // 
            this.AntwoordGrid.AllowUserToAddRows = false;
            this.AntwoordGrid.AllowUserToDeleteRows = false;
            this.AntwoordGrid.AllowUserToOrderColumns = true;
            this.AntwoordGrid.AllowUserToResizeColumns = false;
            this.AntwoordGrid.AllowUserToResizeRows = false;
            this.AntwoordGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AntwoordGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AntwoordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AntwoordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AntwoordGrid.ColumnHeadersHeight = 40;
            this.AntwoordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naam,
            this.TotaleTijd,
            this.gebruiktetijd,
            this.straftijd,
            this.datumentijd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AntwoordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AntwoordGrid.EnableHeadersVisualStyles = false;
            this.AntwoordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.Location = new System.Drawing.Point(11, 140);
            this.AntwoordGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AntwoordGrid.MultiSelect = false;
            this.AntwoordGrid.Name = "AntwoordGrid";
            this.AntwoordGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AntwoordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AntwoordGrid.RowHeadersVisible = false;
            this.AntwoordGrid.RowHeadersWidth = 51;
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.AntwoordGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AntwoordGrid.RowTemplate.Height = 30;
            this.AntwoordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AntwoordGrid.ShowCellErrors = false;
            this.AntwoordGrid.ShowCellToolTips = false;
            this.AntwoordGrid.ShowEditingIcon = false;
            this.AntwoordGrid.ShowRowErrors = false;
            this.AntwoordGrid.Size = new System.Drawing.Size(1882, 891);
            this.AntwoordGrid.TabIndex = 46;
            this.AntwoordGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AntwoordGrid_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // naam
            // 
            this.naam.HeaderText = "Naam";
            this.naam.MinimumWidth = 10;
            this.naam.Name = "naam";
            this.naam.ReadOnly = true;
            this.naam.Width = 200;
            // 
            // TotaleTijd
            // 
            this.TotaleTijd.HeaderText = "Totale Tijd";
            this.TotaleTijd.MinimumWidth = 10;
            this.TotaleTijd.Name = "TotaleTijd";
            this.TotaleTijd.ReadOnly = true;
            this.TotaleTijd.Width = 200;
            // 
            // gebruiktetijd
            // 
            this.gebruiktetijd.HeaderText = "Gebruikte Tijd";
            this.gebruiktetijd.MinimumWidth = 100;
            this.gebruiktetijd.Name = "gebruiktetijd";
            this.gebruiktetijd.ReadOnly = true;
            this.gebruiktetijd.Width = 200;
            // 
            // straftijd
            // 
            this.straftijd.HeaderText = "Straf Tijd";
            this.straftijd.MinimumWidth = 10;
            this.straftijd.Name = "straftijd";
            this.straftijd.ReadOnly = true;
            this.straftijd.Width = 200;
            // 
            // datumentijd
            // 
            this.datumentijd.HeaderText = "Datum en Tijd";
            this.datumentijd.MinimumWidth = 10;
            this.datumentijd.Name = "datumentijd";
            this.datumentijd.ReadOnly = true;
            this.datumentijd.Width = 200;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(21, 50);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(41, 44);
            this.BackBtn.TabIndex = 47;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AntwoordGrid);
            this.Controls.Add(this.VraagLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scores";
            this.Text = "scores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.AntwoordGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.DataGridView AntwoordGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotaleTijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebruiktetijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn straftijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumentijd;
        private System.Windows.Forms.PictureBox BackBtn;
    }
}