namespace TestAndScore
{
    partial class BaoCaoNam
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelTongDeThi = new System.Windows.Forms.Label();
            this.labelTongBaiCham = new System.Windows.Forms.Label();
            this.dataGridViewBaoCaoNam = new System.Windows.Forms.DataGridView();
            this.btnTraCuu = new CustomControls.CustomControls.CustomButton();
            this.cbx_Nam = new System.Windows.Forms.ComboBox();
            this.lb_Tong_De = new System.Windows.Forms.Label();
            this.lb_Tong_Cham = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(226, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo Cáo Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm học:";
            // 
            // labelTongDeThi
            // 
            this.labelTongDeThi.AutoSize = true;
            this.labelTongDeThi.BackColor = System.Drawing.Color.Transparent;
            this.labelTongDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDeThi.Location = new System.Drawing.Point(62, 188);
            this.labelTongDeThi.Name = "labelTongDeThi";
            this.labelTongDeThi.Size = new System.Drawing.Size(137, 24);
            this.labelTongDeThi.TabIndex = 3;
            this.labelTongDeThi.Text = "Tổng số đề thi:";
            // 
            // labelTongBaiCham
            // 
            this.labelTongBaiCham.AutoSize = true;
            this.labelTongBaiCham.BackColor = System.Drawing.Color.Transparent;
            this.labelTongBaiCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongBaiCham.Location = new System.Drawing.Point(438, 188);
            this.labelTongBaiCham.Name = "labelTongBaiCham";
            this.labelTongBaiCham.Size = new System.Drawing.Size(167, 24);
            this.labelTongBaiCham.TabIndex = 4;
            this.labelTongBaiCham.Text = "Tổng số bài chấm:";
            // 
            // dataGridViewBaoCaoNam
            // 
            this.dataGridViewBaoCaoNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaoCaoNam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBaoCaoNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCaoNam.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewBaoCaoNam.Name = "dataGridViewBaoCaoNam";
            this.dataGridViewBaoCaoNam.RowHeadersWidth = 51;
            this.dataGridViewBaoCaoNam.RowTemplate.Height = 24;
            this.dataGridViewBaoCaoNam.Size = new System.Drawing.Size(663, 339);
            this.dataGridViewBaoCaoNam.TabIndex = 5;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.btnTraCuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.btnTraCuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTraCuu.BorderRadius = 15;
            this.btnTraCuu.BorderSize = 0;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(212, 126);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(262, 40);
            this.btnTraCuu.TabIndex = 7;
            this.btnTraCuu.Text = "Xem báo cáo";
            this.btnTraCuu.TextColor = System.Drawing.Color.White;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // cbx_Nam
            // 
            this.cbx_Nam.FormattingEnabled = true;
            this.cbx_Nam.Location = new System.Drawing.Point(326, 82);
            this.cbx_Nam.Name = "cbx_Nam";
            this.cbx_Nam.Size = new System.Drawing.Size(148, 24);
            this.cbx_Nam.TabIndex = 8;
            // 
            // lb_Tong_De
            // 
            this.lb_Tong_De.AutoSize = true;
            this.lb_Tong_De.Location = new System.Drawing.Point(200, 190);
            this.lb_Tong_De.Name = "lb_Tong_De";
            this.lb_Tong_De.Size = new System.Drawing.Size(0, 17);
            this.lb_Tong_De.TabIndex = 9;
            // 
            // lb_Tong_Cham
            // 
            this.lb_Tong_Cham.AutoSize = true;
            this.lb_Tong_Cham.Location = new System.Drawing.Point(605, 190);
            this.lb_Tong_Cham.Name = "lb_Tong_Cham";
            this.lb_Tong_Cham.Size = new System.Drawing.Size(0, 17);
            this.lb_Tong_Cham.TabIndex = 10;
            // 
            // BaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(687, 575);
            this.Controls.Add(this.lb_Tong_Cham);
            this.Controls.Add(this.lb_Tong_De);
            this.Controls.Add(this.cbx_Nam);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.dataGridViewBaoCaoNam);
            this.Controls.Add(this.labelTongBaiCham);
            this.Controls.Add(this.labelTongDeThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaoCaoNam";
            this.Text = "BaoCaoNam";
            this.Load += new System.EventHandler(this.BaoCaoNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCaoNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTongDeThi;
        private System.Windows.Forms.Label labelTongBaiCham;
        private System.Windows.Forms.DataGridView dataGridViewBaoCaoNam;
        private CustomControls.CustomControls.CustomButton btnTraCuu;
        private System.Windows.Forms.ComboBox cbx_Nam;
        private System.Windows.Forms.Label lb_Tong_De;
        private System.Windows.Forms.Label lb_Tong_Cham;
    }
}