
namespace QuizApplicatie
{
    partial class VragenBeheer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VragenBeheer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VragenGrid = new System.Windows.Forms.DataGridView();
            this.VraagLable = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.PictureBox();
            this.AddQuestionBtn = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummerArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caregorieArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditGridBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteGridBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VragenGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddQuestionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.VragenGrid);
            this.panel1.Location = new System.Drawing.Point(11, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1886, 920);
            this.panel1.TabIndex = 9;
            // 
            // VragenGrid
            // 
            this.VragenGrid.AllowUserToAddRows = false;
            this.VragenGrid.AllowUserToDeleteRows = false;
            this.VragenGrid.AllowUserToOrderColumns = true;
            this.VragenGrid.AllowUserToResizeColumns = false;
            this.VragenGrid.AllowUserToResizeRows = false;
            this.VragenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VragenGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VragenGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VragenGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VragenGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VragenGrid.ColumnHeadersHeight = 40;
            this.VragenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nummerArtikel,
            this.naamArtikel,
            this.caregorieArtikel,
            this.EditGridBtn,
            this.DeleteGridBtn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VragenGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.VragenGrid.EnableHeadersVisualStyles = false;
            this.VragenGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VragenGrid.Location = new System.Drawing.Point(2, 1);
            this.VragenGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.VragenGrid.MultiSelect = false;
            this.VragenGrid.Name = "VragenGrid";
            this.VragenGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VragenGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.VragenGrid.RowHeadersVisible = false;
            this.VragenGrid.RowHeadersWidth = 51;
            this.VragenGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.VragenGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.VragenGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.VragenGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.VragenGrid.RowTemplate.Height = 30;
            this.VragenGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VragenGrid.ShowCellErrors = false;
            this.VragenGrid.ShowCellToolTips = false;
            this.VragenGrid.ShowEditingIcon = false;
            this.VragenGrid.ShowRowErrors = false;
            this.VragenGrid.Size = new System.Drawing.Size(1884, 811);
            this.VragenGrid.TabIndex = 43;
            this.VragenGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VragenGrid_CellDoubleClick);
            // 
            // VraagLable
            // 
            this.VraagLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VraagLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VraagLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraagLable.ForeColor = System.Drawing.SystemColors.Control;
            this.VraagLable.Location = new System.Drawing.Point(10, 9);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1887, 118);
            this.VraagLable.TabIndex = 8;
            this.VraagLable.Text = "Vragenbeheer";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(20, 44);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(41, 41);
            this.CancelBtn.TabIndex = 65;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddQuestionBtn
            // 
            this.AddQuestionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.AddQuestionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddQuestionBtn.BackgroundImage")));
            this.AddQuestionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddQuestionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuestionBtn.Location = new System.Drawing.Point(1803, 34);
            this.AddQuestionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuestionBtn.Name = "AddQuestionBtn";
            this.AddQuestionBtn.Size = new System.Drawing.Size(69, 69);
            this.AddQuestionBtn.TabIndex = 66;
            this.AddQuestionBtn.TabStop = false;
            this.AddQuestionBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 608;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 608;
            // 
            // nummerArtikel
            // 
            this.nummerArtikel.HeaderText = "Vraag";
            this.nummerArtikel.MinimumWidth = 600;
            this.nummerArtikel.Name = "nummerArtikel";
            this.nummerArtikel.ReadOnly = true;
            this.nummerArtikel.Width = 600;
            // 
            // naamArtikel
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.naamArtikel.DefaultCellStyle = dataGridViewCellStyle2;
            this.naamArtikel.HeaderText = "Goed Antwoord";
            this.naamArtikel.MinimumWidth = 600;
            this.naamArtikel.Name = "naamArtikel";
            this.naamArtikel.ReadOnly = true;
            this.naamArtikel.Width = 600;
            // 
            // caregorieArtikel
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.caregorieArtikel.DefaultCellStyle = dataGridViewCellStyle3;
            this.caregorieArtikel.HeaderText = "Fout Antwoord";
            this.caregorieArtikel.MinimumWidth = 600;
            this.caregorieArtikel.Name = "caregorieArtikel";
            this.caregorieArtikel.ReadOnly = true;
            this.caregorieArtikel.Width = 600;
            // 
            // EditGridBtn
            // 
            this.EditGridBtn.HeaderText = "";
            this.EditGridBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditGridBtn.Image")));
            this.EditGridBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.EditGridBtn.MinimumWidth = 30;
            this.EditGridBtn.Name = "EditGridBtn";
            this.EditGridBtn.ReadOnly = true;
            this.EditGridBtn.Width = 30;
            // 
            // DeleteGridBtn
            // 
            this.DeleteGridBtn.HeaderText = "";
            this.DeleteGridBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteGridBtn.Image")));
            this.DeleteGridBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.DeleteGridBtn.MinimumWidth = 30;
            this.DeleteGridBtn.Name = "DeleteGridBtn";
            this.DeleteGridBtn.ReadOnly = true;
            this.DeleteGridBtn.Width = 30;
            // 
            // VragenBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.AddQuestionBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.VraagLable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VragenBeheer";
            this.Text = "VragenBeheer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VragenGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddQuestionBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.DataGridView VragenGrid;
        private System.Windows.Forms.PictureBox CancelBtn;
        private System.Windows.Forms.PictureBox AddQuestionBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn caregorieArtikel;
        private System.Windows.Forms.DataGridViewImageColumn EditGridBtn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteGridBtn;
    }
}