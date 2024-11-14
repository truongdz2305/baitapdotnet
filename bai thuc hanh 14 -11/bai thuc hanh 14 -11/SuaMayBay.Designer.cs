namespace bai_thuc_hanh_14__11
{
    partial class SuaMayBay
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
            this.dataGridViewMayBay = new System.Windows.Forms.DataGridView();
            this.txtTenMayBay = new System.Windows.Forms.Label();
            this.txtNamSX = new System.Windows.Forms.Label();
            this.txtSoGioBay = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMayBay
            // 
            this.dataGridViewMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMayBay.Location = new System.Drawing.Point(512, 12);
            this.dataGridViewMayBay.Name = "dataGridViewMayBay";
            this.dataGridViewMayBay.RowHeadersWidth = 51;
            this.dataGridViewMayBay.RowTemplate.Height = 24;
            this.dataGridViewMayBay.Size = new System.Drawing.Size(531, 407);
            this.dataGridViewMayBay.TabIndex = 0;
            this.dataGridViewMayBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMayBay_CellContentClick);
            // 
            // txtTenMayBay
            // 
            this.txtTenMayBay.AutoSize = true;
            this.txtTenMayBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTenMayBay.Location = new System.Drawing.Point(12, 55);
            this.txtTenMayBay.Name = "txtTenMayBay";
            this.txtTenMayBay.Size = new System.Drawing.Size(96, 18);
            this.txtTenMayBay.TabIndex = 1;
            this.txtTenMayBay.Text = "Tên máy bay:";
            // 
            // txtNamSX
            // 
            this.txtNamSX.AutoSize = true;
            this.txtNamSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNamSX.Location = new System.Drawing.Point(12, 114);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(111, 18);
            this.txtNamSX.TabIndex = 2;
            this.txtNamSX.Text = "Năm sản xuất : ";
            this.txtNamSX.Click += new System.EventHandler(this.txtNamSX_Click);
            // 
            // txtSoGioBay
            // 
            this.txtSoGioBay.AutoSize = true;
            this.txtSoGioBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSoGioBay.Location = new System.Drawing.Point(22, 175);
            this.txtSoGioBay.Name = "txtSoGioBay";
            this.txtSoGioBay.Size = new System.Drawing.Size(86, 18);
            this.txtSoGioBay.TabIndex = 3;
            this.txtSoGioBay.Text = "Số giờ bay :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(143, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(324, 22);
            this.txtTen.TabIndex = 4;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(143, 109);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(323, 22);
            this.txtNam.TabIndex = 5;
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(143, 172);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(322, 22);
            this.txtGio.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(54, 287);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 74);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(314, 290);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 70);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // SuaMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSoGioBay);
            this.Controls.Add(this.txtNamSX);
            this.Controls.Add(this.txtTenMayBay);
            this.Controls.Add(this.dataGridViewMayBay);
            this.Name = "SuaMayBay";
            this.Text = "SuaMayBay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMayBay;
        private System.Windows.Forms.Label txtTenMayBay;
        private System.Windows.Forms.Label txtNamSX;
        private System.Windows.Forms.Label txtSoGioBay;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
    }
}