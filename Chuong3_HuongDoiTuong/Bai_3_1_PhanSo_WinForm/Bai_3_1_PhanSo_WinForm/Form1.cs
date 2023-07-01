using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_3_1_PhanSo_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHANSO a, b, kq;
            a = new PHANSO();
            kq = new PHANSO();

            try
            {
                a.TS = int.Parse(txtTu1.Text);
                a.MS = int.Parse(txtMau1.Text);

                b = new PHANSO(int.Parse(txtTu2.Text),
                    int.Parse(txtMau2.Text));
                kq = a.tong(b);

                txtTu.Text = kq.TS.ToString();
                txtMau.Text = kq.MS.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Err!");
            }
            /*
            finally
            {
                txtMau.Clear();
                txtTu.Clear();
                txtMau1.Clear();
                txtTu1.Clear();
                txtMau2.Clear();
                txtTu2.Clear();
            }
             */
        }
    }

    public class PHANSO
    {
        private int ts, ms;
        public PHANSO()
        {
            ts = 0; ms = 1;
        }

        public PHANSO(int t, int m)
        {
            ts = t; ms = m;
        }

        //thuộc tính 
        public int TS
        {
            get { return ts; }
            set { ts = value; }
        }

        public int MS
        {
            get { return ms; }
            set { ms = value; }
        }

        //phương thức tổng
        public PHANSO tong(PHANSO a)
        {
            PHANSO k = new PHANSO();
            k.ts = ts * a.ms + a.ts * ms;
            k.ms = ms * a.ms;

            return k;
        }
    }

}
