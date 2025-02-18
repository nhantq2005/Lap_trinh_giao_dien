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

        public int Cong()
        {
            return checked(this.n1+this.n2);
        }

        public int Tru()
        {
            return checked(this.n1 - this.n2);
        }
        public int Nhan()
        {
            return checked(this.n1 * this.n2);
        }
        public double Chia()
        {
            if (n2 == 0)
                throw new DivideByZeroException();
            return Math.Round((double)this.n1 / this.n2,2);
        }

        public int ChiaDu()
        {
            return checked(this.n1 % this.n2);
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
                //if (pt.KiemTra() != "")
                //{
                //    output.Text = pt.KiemTra();
                //}
                //else
                //{
                    if (plusRB.Checked)
                    {
                        output.Text = pt.Cong().ToString();
                    }
                    else if (minusRB.Checked)
                    {
                        output.Text = pt.Tru().ToString();
                    }
                    else if (timesRB.Checked)
                    {
                        output.Text = pt.Nhan().ToString();
                    }
                    else if (divRB.Checked)
                    {
                        output.Text = pt.Chia().ToString();
                    }
                    else
                    {
                        output.Text = pt.ChiaDu().ToString();
                    }
                //}
            }catch(FormatException)
            {
                output.Text = "Bạn phải nhập 2 số";
            }catch(OverflowException)
            {
                output.Text = "Không thể xử lý số quá lớn";
            }catch(DivideByZeroException)
            {
                output.Text = "Số chia phải khác 0";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng?","Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}
