namespace TestAndScore
{
    partial class DSChamThi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthibangso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthibangchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kết Quả Chấm Thi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.maDT,
            this.lanthi,
            this.diemthibangso,
            this.diemthibangchu,
            this.ghichu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 497);
            this.dataGridView1.TabIndex = 3;
            // 
            // mssv
            // 
            this.mssv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mssv.DataPropertyName = "mssv";
            this.mssv.HeaderText = "MSSV";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            this.mssv.Width = 74;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 75;
            // 
            // maDT
            // 
            this.maDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maDT.DataPropertyName = "maDT";
            this.maDT.HeaderText = "Mã đề thi";
            this.maDT.MinimumWidth = 6;
            this.maDT.Name = "maDT";
            this.maDT.ReadOnly = true;
            this.maDT.Width = 90;
            // 
            // lanthi
            // 
            this.lanthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lanthi.DataPropertyName = "lanthi";
            this.lanthi.HeaderText = "Lần thi";
            this.lanthi.MinimumWidth = 6;
            this.lanthi.Name = "lanthi";
            this.lanthi.ReadOnly = true;
            this.lanthi.Width = 74;
            // 
            // diemthibangso
            // 
            this.diemthibangso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemthibangso.DataPropertyName = "diemthibangso";
            this.diemthibangso.HeaderText = "Điểm (số)";
            this.diemthibangso.MinimumWidth = 6;
            this.diemthibangso.Name = "diemthibangso";
            this.diemthibangso.ReadOnly = true;
            this.diemthibangso.Width = 93;
            // 
            // diemthibangchu
            // 
            this.diemthibangchu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diemthibangchu.DataPropertyName = "diemthibangchu";
            this.diemthibangchu.HeaderText = "Điểm (chữ)";
            this.diemthibangchu.MinimumWidth = 6;
            this.diemthibangchu.Name = "diemthibangchu";
            this.diemthibangchu.ReadOnly = true;
            this.diemthibangchu.Width = 99;
            // 
            // ghichu
            // 
            this.ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // DSChamThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(687, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DSChamThi";
            this.Text = "DSChamThi";
            this.Load += new System.EventHandler(this.DSChamThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthibangso;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthibangchu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}