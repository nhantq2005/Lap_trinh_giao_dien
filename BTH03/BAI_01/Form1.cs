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
            //Tao phan so lan dau chay
            p1.SinhPS();
            p2.SinhPS();
            //Hien thi 2 phan so
            ts1.Text = p1.Tuso.ToString();
            ms1.Text = p1.Mauso.ToString();
            ts2.Text = p2.Tuso.ToString();
            ms2.Text = p2.Mauso.ToString();
        }

        private void congBtn_Click(object sender, EventArgs e)
        {
            phepTinh.Text = "+";;
            PhanSo dapAn = new PhanSo(p1.Cong(p2).Tuso, p1.Cong(p2).Mauso);
            PhanSo psKQ = new PhanSo(int.Parse(tsKQ.Text), int.Parse(msKQ.Text));
            hienThiDA.Text=psKQ.KiemTra(dapAn);

        }

        private void truBtn_Click(object sender, EventArgs e)
        {
            phepTinh.Text = "+"; ;
            PhanSo dapAn = new PhanSo(p1.Tru(p2).Tuso, p1.Tru(p2).Mauso);
            PhanSo psKQ = new PhanSo(int.Parse(tsKQ.Text), int.Parse(msKQ.Text));
            hienThiDA.Text = psKQ.KiemTra(dapAn);
        }

        private void nhanBtn_Click(object sender, EventArgs e)
        {
            phepTinh.Text = "+"; ;
            PhanSo dapAn = new PhanSo(p1.Nhan(p2).Tuso, p1.Nhan(p2).Mauso);
            PhanSo psKQ = new PhanSo(int.Parse(tsKQ.Text), int.Parse(msKQ.Text));
            hienThiDA.Text = psKQ.KiemTra(dapAn);
        }

        private void chiaBtn_Click(object sender, EventArgs e)
        {
            phepTinh.Text = "+"; ;
            PhanSo dapAn = new PhanSo(p1.Chia(p2).Tuso, p1.Chia(p2).Mauso);
            PhanSo psKQ = new PhanSo(int.Parse(tsKQ.Text), int.Parse(msKQ.Text));
            hienThiDA.Text = psKQ.KiemTra(dapAn);
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            //Tao phan so moi
            p1.SinhPS();
            p2.SinhPS();
            //Hien thi 2 phan so
            ts1.Text = p1.Tuso.ToString();
            ms1.Text = p1.Mauso.ToString();
            ts2.Text = p2.Tuso.ToString();
            ms2.Text = p2.Mauso.ToString();
        }
    }
}
