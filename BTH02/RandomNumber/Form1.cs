using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {

        struct SoNgauNhien
        {
            int n1, n2, n3;
            int max, min,tong;
            int diem;

            public int N1
            {
                get { return n1; }
                set { n1 = value; }
            }

            public int N2
            {
                get { return n2; }
                set { n2 = value; }
            }

            public int N3
            {
                get { return n3; }
                set { n3 = value; }
            }

            public int Max
            {
                get { return max; }
                set { max = value; }
            }

            public int Min
            {
                get { return min; }
                set {  min = value; }
            }

            public int Diem
            {
                get { return diem; }
                set {  diem = value; }
            }

            public void TaoSo()
            {
                Random r = new Random();
                this.n1 = r.Next(1, 7);
                this.n2 = r.Next(1, 7);
                this.n3 = r.Next(1, 7);
            }

            public void isThoaMan()
            {
                if (n1 + n2 + n3 <= max && n1 + n2 + n3 >= min)
                {
                    diem += 10;
                }
                else
                {
                    if (diem != 0)
                    {
                        diem -= 10;
                    }
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
        SoNgauNhien s = new SoNgauNhien();
        private void button2_Click(object sender, EventArgs e)
        {
            //Hien thi tren man hinh
            s.TaoSo();
            n1.Text = s.N1.ToString();
            n2.Text = s.N2.ToString();
            n3.Text = s.N3.ToString();
            //Tinh diem
            s.isThoaMan();
            //Hien thi diem
            diemSo.Text=s.Diem.ToString();
        }

        private void opt1_Click(object sender, EventArgs e)
        {
            s.Max = 10;
            s.Min = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Max = 18;
            s.Min = 11;
        }
    }
}
