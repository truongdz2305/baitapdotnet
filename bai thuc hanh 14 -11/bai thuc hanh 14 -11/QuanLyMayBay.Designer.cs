namespace bai_thuc_hanh_14__11
{
    partial class QuanLyMayBay
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
            this.btnXemMayBay = new System.Windows.Forms.Button();
            this.btnThemMayBay = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnSuaMayBay = new System.Windows.Forms.Button();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemMayBay
            // 
            this.btnXemMayBay.Location = new System.Drawing.Point(62, 198);
            this.btnXemMayBay.Name = "btnXemMayBay";
            this.btnXemMayBay.Size = new System.Drawing.Size(125, 59);
            this.btnXemMayBay.TabIndex = 0;
            this.btnXemMayBay.Text = "Xem Máy Bay";
            this.btnXemMayBay.UseVisualStyleBackColor = true;
            this.btnXemMayBay.Click += new System.EventHandler(this.btnXemMayBay_Click);
            // 
            // btnThemMayBay
            // 
            this.btnThemMayBay.Location = new System.Drawing.Point(284, 198);
            this.btnThemMayBay.Name = "btnThemMayBay";
            this.btnThemMayBay.Size = new System.Drawing.Size(145, 58);
            this.btnThemMayBay.TabIndex = 1;
            this.btnThemMayBay.Text = "Thêm Máy Bay";
            this.btnThemMayBay.UseVisualStyleBackColor = true;
            this.btnThemMayBay.Click += new System.EventHandler(this.btnThemMayBay_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(10, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(10, 10);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btnSuaMayBay
            // 
            this.btnSuaMayBay.Location = new System.Drawing.Point(537, 201);
            this.btnSuaMayBay.Name = "btnSuaMayBay";
            this.btnSuaMayBay.Size = new System.Drawing.Size(134, 56);
            this.btnSuaMayBay.TabIndex = 4;
            this.btnSuaMayBay.Text = "Sửa Máy Bay";
            this.btnSuaMayBay.UseVisualStyleBackColor = true;
            this.btnSuaMayBay.Click += new System.EventHandler(this.btnSuaMayBay_Click);
            // 
            // QuanLyMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuaMayBay);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThemMayBay);
            this.Controls.Add(this.btnXemMayBay);
            this.Name = "QuanLyMayBay";
            this.Text = "QuanLyMayBay";
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemMayBay;
        private System.Windows.Forms.Button btnThemMayBay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnSuaMayBay;
    }
}