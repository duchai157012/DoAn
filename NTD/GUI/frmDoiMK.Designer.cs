namespace NTD.GUI
{
    partial class frmDoiMK
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu cũ";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(133, 81);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(236, 20);
            this.txtMKCu.TabIndex = 4;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(133, 113);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(236, 20);
            this.txtMKMoi.TabIndex = 5;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(133, 145);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(236, 20);
            this.txtNhapLai.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(160, 210);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Đồng Ý";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(254, 210);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 8;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 268);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.TextEdit txtNhapLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btndong;
    }
}