using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_01
{
    public partial class Form1 : Form
    {
        PhanSo p1 = new PhanSo();
        PhanSo p2 = new PhanSo();
        public Form1()
        {
            InitializeComponent();
        }

        private void congBtn_Click(object sender, EventArgs e)
        {
            p1.Tuso = int.Parse(ts1.Text);
            p1.Mauso = int.Parse(ms1.Text);
            p2.Tuso = int.Parse(ts2.Text);
            p2.Mauso = int.Parse(ms2.Text);

            phepTinh.Text = "+";
            tsKQ.Text = p1.Cong(p2).Tuso.ToString();
            msKQ.Text = p1.Cong(p2).Mauso.ToString();
        }

        private void truBtn_Click(object sender, EventArgs e)
        {
            p1.Tuso = int.Parse(ts1.Text);
            p1.Mauso = int.Parse(ms1.Text);
            p2.Tuso = int.Parse(ts2.Text);
            p2.Mauso = int.Parse(ms2.Text);

            phepTinh.Text = "-";
            tsKQ.Text = p1.Tru(p2).Tuso.ToString();
            msKQ.Text = p1.Tru(p2).Mauso.ToString();
        }

        private void nhanBtn_Click(object sender, EventArgs e)
        {
            p1.Tuso = int.Parse(ts1.Text);
            p1.Mauso = int.Parse(ms1.Text);
            p2.Tuso = int.Parse(ts2.Text);
            p2.Mauso = int.Parse(ms2.Text);

            phepTinh.Text = "*";
            tsKQ.Text = p1.Nhan(p2).Tuso.ToString();
            msKQ.Text = p1.Nhan(p2).Mauso.ToString();
        }

        private void chiaBtn_Click(object sender, EventArgs e)
        {
            p1.Tuso = int.Parse(ts1.Text);
            p1.Mauso = int.Parse(ms1.Text);
            p2.Tuso = int.Parse(ts2.Text);
            p2.Mauso = int.Parse(ms2.Text);

            phepTinh.Text = "/";
            tsKQ.Text = p1.Chia(p2).Tuso.ToString();
            msKQ.Text = p1.Chia(p2).Mauso.ToString();
        }
    }
}
