namespace bai_thuc_hanh_14__11
{
    partial class ThemMayBay
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
            this.lblTenMayBay = new System.Windows.Forms.Label();
            this.lblNamSX = new System.Windows.Forms.Label();
            this.lblSoGioBay = new System.Windows.Forms.Label();
            this.txtTenMayBay = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.txtSoGioBay = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dataGridViewMayBay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMayBay
            // 
            this.lblTenMayBay.AutoSize = true;
            this.lblTenMayBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTenMayBay.Location = new System.Drawing.Point(12, 133);
            this.lblTenMayBay.Name = "lblTenMayBay";
            this.lblTenMayBay.Size = new System.Drawing.Size(96, 18);
            this.lblTenMayBay.TabIndex = 0;
            this.lblTenMayBay.Text = "Tên máy bay ";
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNamSX.Location = new System.Drawing.Point(12, 196);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(104, 18);
            this.lblNamSX.TabIndex = 2;
            this.lblNamSX.Text = "Năm Sản Xuất";
            // 
            // lblSoGioBay
            // 
            this.lblSoGioBay.AutoSize = true;
            this.lblSoGioBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSoGioBay.Location = new System.Drawing.Point(12, 252);
            this.lblSoGioBay.Name = "lblSoGioBay";
            this.lblSoGioBay.Size = new System.Drawing.Size(84, 18);
            this.lblSoGioBay.TabIndex = 3;
            this.lblSoGioBay.Text = "Số Giờ Bay";
            // 
            // txtTenMayBay
            // 
            this.txtTenMayBay.Location = new System.Drawing.Point(137, 132);
            this.txtTenMayBay.Name = "txtTenMayBay";
            this.txtTenMayBay.Size = new System.Drawing.Size(202, 22);
            this.txtTenMayBay.TabIndex = 5;
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(138, 192);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(201, 22);
            this.txtNamSX.TabIndex = 6;
            // 
            // txtSoGioBay
            // 
            this.txtSoGioBay.Location = new System.Drawing.Point(140, 252);
            this.txtSoGioBay.Name = "txtSoGioBay";
            this.txtSoGioBay.Size = new System.Drawing.Size(198, 22);
            this.txtSoGioBay.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 327);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 58);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(215, 329);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 55);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dataGridViewMayBay
            // 
            this.dataGridViewMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMayBay.Location = new System.Drawing.Point(376, 65);
            this.dataGridViewMayBay.Name = "dataGridViewMayBay";
            this.dataGridViewMayBay.RowHeadersWidth = 51;
            this.dataGridViewMayBay.RowTemplate.Height = 24;
            this.dataGridViewMayBay.Size = new System.Drawing.Size(529, 345);
            this.dataGridViewMayBay.TabIndex = 10;
            // 
            // ThemMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.dataGridViewMayBay);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoGioBay);
            this.Controls.Add(this.txtNamSX);
            this.Controls.Add(this.txtTenMayBay);
            this.Controls.Add(this.lblSoGioBay);
            this.Controls.Add(this.lblNamSX);
            this.Controls.Add(this.lblTenMayBay);
            this.Name = "ThemMayBay";
            this.Text = "ThemMayBay";
            this.Load += new System.EventHandler(this.ThemMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMayBay;
        private System.Windows.Forms.Label lblNamSX;
        private System.Windows.Forms.Label lblSoGioBay;
        private System.Windows.Forms.TextBox txtTenMayBay;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.TextBox txtSoGioBay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dataGridViewMayBay;
    }
}