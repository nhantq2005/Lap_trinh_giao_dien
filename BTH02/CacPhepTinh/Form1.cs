using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacPhepTinh
{
    public partial class Form1 : Form
    {
        struct PhepTinh
        {
            double num1, num2;
            public PhepTinh(double num1, double num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public double Num1
            {
                get { return num1; }
                set { num1 = value; }
            }

            public double Num2
            {
                get { return num2; }
                set { num2 = value; }
            }

            public string Cong()
            {
                return (this.num1 + this.num2).ToString();
            }

            public string Tru()
            {
                return (this.num1 - this.num2).ToString();
            }

            public string Nhan()
            {
                return (this.num1 * this.num2).ToString();
            }

            public string Chia()
            {
                if(this.num2 == 0)
                {
                    return "Số chia phải khác 0";
                }
                return Math.Round(this.num1 / this.num2,2).ToString();
            }

            public double getNum1() { return num1; }
            public double getNum2() { return num2; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        

        private void plusbtn_Click(object sender, EventArgs e)
        {
            PhepTinh pt = new PhepTinh(double.Parse(input1.Text), double.Parse(input2.Text));
            output.Text = pt.Cong();
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            PhepTinh pt = new PhepTinh(double.Parse(input1.Text), double.Parse(input2.Text));
            output.Text = pt.Tru();
        }

        private void timesbtn_Click(object sender, EventArgs e)
        {
            PhepTinh pt = new PhepTinh(double.Parse(input1.Text), double.Parse(input2.Text));
            output.Text = pt.Nhan();
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            PhepTinh pt = new PhepTinh(double.Parse(input1.Text), double.Parse(input2.Text));
            output.Text = pt.Chia();
        }
    }
}
