
namespace PlayerUI
{
    partial class DSCauHoi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.mamon,
            this.dokho,
            this.noidung});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(933, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "Collum1";
            this.MaCH.HeaderText = "Mã câu hỏi";
            this.MaCH.MinimumWidth = 8;
            this.MaCH.Name = "MaCH";
            this.MaCH.ReadOnly = true;
            this.MaCH.Width = 150;
            // 
            // mamon
            // 
            this.mamon.HeaderText = "Mã môn học";
            this.mamon.MinimumWidth = 8;
            this.mamon.Name = "mamon";
            this.mamon.ReadOnly = true;
            this.mamon.Width = 150;
            // 
            // dokho
            // 
            this.dokho.HeaderText = "Độ khó";
            this.dokho.MinimumWidth = 8;
            this.dokho.Name = "dokho";
            this.dokho.ReadOnly = true;
            this.dokho.Width = 150;
            // 
            // noidung
            // 
            this.noidung.HeaderText = "Nội dung";
            this.noidung.MinimumWidth = 8;
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            this.noidung.Width = 150;
            // 
            // DSCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(978, 719);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DSCauHoi";
            this.Text = "Danh sach cau hoi";
            this.Load += new System.EventHandler(this.DSCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokho;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
    }
}