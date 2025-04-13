using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_MAU_02
{
    public partial class FrmMain : Form
    {
        Dictionary<String,String> luaChon = new Dictionary<String,String>();
        int tienConLai = 1000;
        int tienDatCuoc;

        public FrmMain()
        {
            FrmDelay fd = new FrmDelay();   
            fd.ShowDialog();
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            luaChon.Add("Nai", "1");
            luaChon.Add("Bầu", "2");
            luaChon.Add("Gà", "3");
            luaChon.Add("Cá", "4");
            luaChon.Add("Cua", "5");
            luaChon.Add("Tôm", "6");
            foreach (string s in luaChon.Keys)
                {
                    boxLuaChon.Items.Add(s);
                }
                lbConLai.Text=tienConLai.ToString();
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int SLDung = 0;
                rsl1.Tag = rnd.Next(1, 7).ToString() + ".png";
                rsl1.Image = Image.FromFile(rsl1.Tag.ToString());
                rsl2.Tag = rnd.Next(1, 7).ToString() + ".png";
                rsl2.Image = Image.FromFile(rsl2.Tag.ToString());
                rsl3.Tag = rnd.Next(1, 7).ToString() + ".png";
                rsl3.Image = Image.FromFile(rsl3.Tag.ToString());
                if (int.Parse(tienCuoc.Text) > tienConLai)
                {
                    MessageBox.Show("KHONG DU TIEN CUOC", "CANH BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (rsl1.Tag.ToString() == luaChon[boxLuaChon.SelectedItem.ToString()]+".png") SLDung++;
                if (rsl2.Tag.ToString() == luaChon[boxLuaChon.SelectedItem.ToString()] + ".png") SLDung++;
                if (rsl3.Tag.ToString() == luaChon[boxLuaChon.SelectedItem.ToString()] + ".png") SLDung++;

                if (SLDung > 0)
                {
                    tienConLai += SLDung * int.Parse(tienCuoc.Text);
                }
                else
                {
                    tienConLai -= int.Parse(tienCuoc.Text);
                }
                lbConLai.Text=tienConLai.ToString();

                if (tienConLai <= 0)
                {
                    btQuay.Enabled = false;
                }
            }
            catch { }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đóng chương trình?","Chú ý!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}
