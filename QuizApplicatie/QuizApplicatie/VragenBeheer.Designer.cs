
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VragenBeheer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VragenGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummerArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caregorieArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.VraagLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VragenGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(106)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.VragenGrid);
            this.panel1.Location = new System.Drawing.Point(40, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3445, 1628);
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
            this.EditBtn,
            this.DeleteBtn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VragenGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.VragenGrid.EnableHeadersVisualStyles = false;
            this.VragenGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VragenGrid.Location = new System.Drawing.Point(35, 28);
            this.VragenGrid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.VragenGrid.MultiSelect = false;
            this.VragenGrid.Name = "VragenGrid";
            this.VragenGrid.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VragenGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.VragenGrid.Size = new System.Drawing.Size(1838, 847);
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
            this.VraagLable.Location = new System.Drawing.Point(40, 50);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(3445, 220);
            this.VraagLable.TabIndex = 8;
            this.VraagLable.Text = "Vragenbeheer";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(59, 113);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 81);
            this.BackBtn.TabIndex = 44;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nummerArtikel
            // 
            this.nummerArtikel.HeaderText = "Vraag";
            this.nummerArtikel.MinimumWidth = 550;
            this.nummerArtikel.Name = "nummerArtikel";
            this.nummerArtikel.ReadOnly = true;
            this.nummerArtikel.Width = 550;
            // 
            // naamArtikel
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.naamArtikel.DefaultCellStyle = dataGridViewCellStyle2;
            this.naamArtikel.HeaderText = "Goed Antwoord";
            this.naamArtikel.MinimumWidth = 550;
            this.naamArtikel.Name = "naamArtikel";
            this.naamArtikel.ReadOnly = true;
            this.naamArtikel.Width = 550;
            // 
            // caregorieArtikel
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.caregorieArtikel.DefaultCellStyle = dataGridViewCellStyle3;
            this.caregorieArtikel.HeaderText = "Fout Antwoord";
            this.caregorieArtikel.MinimumWidth = 550;
            this.caregorieArtikel.Name = "caregorieArtikel";
            this.caregorieArtikel.ReadOnly = true;
            this.caregorieArtikel.Width = 550;
            // 
            // EditBtn
            // 
            this.VraagLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VraagLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.VraagLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraagLable.ForeColor = System.Drawing.SystemColors.Control;
            this.VraagLable.Location = new System.Drawing.Point(22, 27);
            this.VraagLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VraagLable.Name = "VraagLable";
            this.VraagLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VraagLable.Size = new System.Drawing.Size(1879, 119);
            this.VraagLable.TabIndex = 8;
            this.VraagLable.Text = "Vragenbeheer";
            this.VraagLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(93)))), ((int)(((byte)(171)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Location = new System.Drawing.Point(32, 61);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(41, 44);
            this.BackBtn.TabIndex = 44;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // VragenBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(2288, 1923);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.VraagLable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VragenBeheer";
            this.Text = "VragenBeheer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VragenGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VraagLable;
        private System.Windows.Forms.DataGridView VragenGrid;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn caregorieArtikel;
        private System.Windows.Forms.PictureBox BackBtn;
    }
}