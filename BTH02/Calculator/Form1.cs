using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    struct PhepTinh
    {
        int n1, n2;

        public PhepTinh(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

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

        public string KiemTra()
        {
            if (n1 > 100 || n2 > 100 || n1 < -100 || n2 < -100)
            {
                return "Không thể xử lý số quá lớn";
            }else if(n1==null||n2==null)
            {
                return "Bạn phải nhập 2 số";
            }
            return"";
        }

        public string Cong()
        {
            return (this.n1+this.n2).ToString();
        }

        public string Tru()
        {
            return (this.n1 - this.n2).ToString();
        }
        public string Nhan()
        {
            return (this.n1 * this.n2).ToString();
        }
        public string Chia()
        {
            if (this.n2 == 0)
            {
                return "Số chia phải khác 0";
            }
            return Math.Round((double)this.n1 / this.n2,2).ToString();
        }

        public string ChiaDu()
        {
            if (this.n2 == 0)
            {
                return "Số chia phải khác 0";
            }
            return (this.n1 % this.n2).ToString();
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PhepTinh pt = new PhepTinh(int.Parse(input1.Text), int.Parse(input2.Text));
                if (pt.KiemTra() != "")
                {
                    output.Text = pt.KiemTra();
                }
                else
                {
                    if (plusRB.Checked)
                    {
                        output.Text = pt.Cong();
                    }
                    else if (minusRB.Checked)
                    {
                        output.Text = pt.Tru();
                    }
                    else if (timesRB.Checked)
                    {
                        output.Text = pt.Nhan();
                    }
                    else if (divRB.Checked)
                    {
                        output.Text = pt.Chia();
                    }
                    else
                    {
                        output.Text = pt.ChiaDu();
                    }
                }
            }catch(FormatException)
            {
                output.Text = "Bạn phải nhập 2 số";
            }
            
        }
    }
}
