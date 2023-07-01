using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_1_2_TinhTong_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(txtSo.Text);
                if (n <= 0)
                {
                    MessageBox.Show("Bạn phải nhập số nguyên dương", "Lỗi");
                    txtSo.Clear();
                    return;
                }
                int tong = 0;
                for (int i = 1; i <= n; i++)
                    tong += i;
                lblKQ.Text = "Tổng các số nguyên từ 1 đến " + n.ToString() + " = " + tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                txtSo.Clear();
            }
            

        }      
    }
}
