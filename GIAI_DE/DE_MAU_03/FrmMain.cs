using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_MAU_03
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random();
        int tienConLai = 1000;
        int[] luaChon = { 100, 200, 300, 400, 500 };
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbTienConLai.Text=tienConLai.ToString();
            foreach(int i in luaChon)
            {
                tienCL.Items.Add(i);
                tienTS.Items.Add(i);
            }

            tienCL.SelectedValue = 100;
            tienTS.SelectedValue = 100;


        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            int ranNum1 = rnd.Next(1, 7);
            int ranNum2 = rnd.Next(1, 7);
            int ranNum3 = rnd.Next(1, 7);

            if (tienConLai < (int.Parse(tienCL.Text) + int.Parse(tienTS.Text)))
            {
                MessageBox.Show("Tổng tiền cược không được lớn hơn tổng tiền còn lại", "", MessageBoxButtons.OK);
            }

            if (GUI.Checked)
            {
                lbN1.Visible = false;
                lbN2.Visible = false;
                lbN3.Visible = false;

                picN1.Visible = true;
                picN2.Visible = true;
                picN3.Visible = true;

                picN1.Image = Image.FromFile(ranNum1 + ".png");
                picN2.Image = Image.FromFile(ranNum2 + ".png");
                picN3.Image = Image.FromFile(ranNum3 + ".png");
            }
            else
            {
                picN1.Visible = false;
                picN2.Visible = false;
                picN3.Visible = false;

                lbN1.Visible = true;
                lbN2.Visible = true;
                lbN3.Visible = true;

                lbN1.Text = ranNum1.ToString();
                lbN2.Text = ranNum2.ToString();
                lbN3.Text = ranNum3.ToString();
            }



            if(rdChan.Checked && (ranNum1 + ranNum2 + ranNum3) % 2 == 0)
            {
                tienConLai += int.Parse(tienCL.Text);
            }
            else if(!rdChan.Checked && (ranNum1 + ranNum2 + ranNum3) % 2 != 0)
            {
                tienConLai += int.Parse(tienCL.Text);
            }
            else
            {
                tienConLai -= int.Parse(tienCL.Text);
            }

            if (rdTu3.Checked && (ranNum1 + ranNum2 + ranNum3) >= 3 && (ranNum1 + ranNum2 + ranNum3) <= 10)
            {
                tienConLai += int.Parse(tienTS.Text);
            }
            else if (rdTu3.Checked && (ranNum1 + ranNum2 + ranNum3) >= 11 && (ranNum1 + ranNum2 + ranNum3) <= 18){
                tienConLai += int.Parse(tienTS.Text);

            }
            else
            {
                tienConLai -= int.Parse(tienCL.Text);
            }
            lbTienConLai.Text = tienConLai.ToString();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Đóng ứng dụng?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) {
            e.Cancel = true;
            }
        }
    }
}
