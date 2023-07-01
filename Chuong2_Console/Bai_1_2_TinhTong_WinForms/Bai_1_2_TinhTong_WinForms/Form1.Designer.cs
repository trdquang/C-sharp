namespace Bai_1_2_TinhTong_WinForms
{
    partial class Form1
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
            this.lblTenCT = new System.Windows.Forms.Label();
            this.lblSoNguyen = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenCT
            // 
            this.lblTenCT.AutoSize = true;
            this.lblTenCT.Location = new System.Drawing.Point(120, 32);
            this.lblTenCT.Name = "lblTenCT";
            this.lblTenCT.Size = new System.Drawing.Size(463, 21);
            this.lblTenCT.TabIndex = 0;
            this.lblTenCT.Text = "CHƯƠNG TRÌNH TÍNH TỔNG SỐ NGUYÊN TỪ 1 ĐẾN N";
            // 
            // lblSoNguyen
            // 
            this.lblSoNguyen.AutoSize = true;
            this.lblSoNguyen.ForeColor = System.Drawing.Color.Red;
            this.lblSoNguyen.Location = new System.Drawing.Point(173, 118);
            this.lblSoNguyen.Name = "lblSoNguyen";
            this.lblSoNguyen.Size = new System.Drawing.Size(162, 21);
            this.lblSoNguyen.TabIndex = 1;
            this.lblSoNguyen.Text = "Số nguyên dương";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(353, 118);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(138, 28);
            this.txtSo.TabIndex = 2;
            // 
            // btnTinh
            // 
            this.btnTinh.ForeColor = System.Drawing.Color.Red;
            this.btnTinh.Location = new System.Drawing.Point(353, 170);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 29);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.ForeColor = System.Drawing.Color.Red;
            this.lblKQ.Location = new System.Drawing.Point(349, 248);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(15, 21);
            this.lblKQ.TabIndex = 1;
            this.lblKQ.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(759, 406);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblSoNguyen);
            this.Controls.Add(this.lblTenCT);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Chương trình tính tổng đơn giản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenCT;
        private System.Windows.Forms.Label lblSoNguyen;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblKQ;
    }
}

