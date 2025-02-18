using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behoctoan
{
    public partial class Form1 : Form
    {
        struct PhepToan
        {
            int n1, n2;
            int ketQua;


            public PhepToan(int n1, int n2)
            {
                this.n1 = n1;
                this.n2 = n2;
                this.ketQua = 0;
            }

            public void taoGiaTri()
            {
                Random r = new Random();
                n1 = r.Next(10);
                n2 = r.Next(1,10);
            }

            public void tinhKetQua(string toanTu)
            {
                switch (toanTu)
                {
                    case "+":
                        {
                            this.ketQua = this.n1 + this.n2;
                            break;
                        }
                    case "-":
                        {
                            this.ketQua = this.n1 - this.n2;
                            break;
                        }
                    case "x":
                        {
                            this.ketQua = this.n1 * this.n2;
                            break;
                        }
                    case ":":
                        {
                            this.ketQua = this.n1 / this.n2;
                            break;
                        }
                }
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

            public int KetQua
            {
                get { return ketQua; }
                set { ketQua = value; }
            }

        }

        //struct PhepToan
        //{
        //    int n1, n2;
        //    int ketQua;

        //    public PhepToan(int n1, int n2)
        //    {
        //        this.n1 = n1;
        //        this.n2 = n2;
        //        this.ketQua = n2;
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
        }

        string[] toanTu = { "+", "-", "x", ":" };
        int viTri = 0;
        int kq;
        PhepToan pt = new PhepToan();
        Random r = new Random();

        private void btnhienKQ_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy giá trị người dùng nhập
                kq = int.Parse(input.Text);
                //Tinh gia tri
                pt.tinhKetQua(toanTu[viTri]);
            }
            catch (FormatException)
            {
                ketQua.Text = "Bạn phải nhập kết quả";
            }
               
            if (kq == pt.KetQua)
            {
                ketQua.Text = "Đúng rồi!";
            }
            else
            {
                ketQua.Text=String.Format("Sai rồi. Kết quả là: {0}",pt.KetQua);
            }

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            //Xóa gtri trước
            ketQua.Text = "";
            input.Text = "";
            //Tạo gtri mới
            pt.taoGiaTri();
            //Hien thi phep tinh
            n1.Text = pt.N1.ToString();
            n2.Text = pt.N2.ToString();
            //Chon phep tinh
            viTri = r.Next(4);
            phepTinh.Text = toanTu[viTri];

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input.Text += btn0.Text;
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            if (input.Text != null) return;
            input.Text = "-";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(input.Text == null) return;
            input.Text = input.Text.Substring(0,input.Text.Length-1);
        }
    }
}
