using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_MAU_01
{
    enum Huong
    {
        LEN, XUONG, TRAI, PHAI
    }
    public partial class FrmImage : Form
    {
        Image img;
        Huong huong;
        public FrmImage()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: huong = Huong.LEN; break;
                case Keys.Down: huong = Huong.XUONG; break;
                case Keys.Left: huong = Huong.TRAI; break;
                case Keys.Right: huong = Huong.PHAI; break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {
            img = Image.FromFile("pen.png");
            pic.Image = img;
            huong = Huong.TRAI;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(huong)
            {
                case Huong.LEN: pic.Top -= 5;
                    if(pic.Bottom<=0)
                    {
                        pic.Top = ClientRectangle.Height;
                    }
                    break;
                case Huong.XUONG: pic.Top += 5;
                    if(pic.Top>=ClientRectangle.Height)
                    {
                        pic.Top = -pic.Height;
                    }
                    break;
                case Huong.TRAI: pic.Left -= 5;
                    if (pic.Right <= 0)
                    {
                        pic.Left = ClientRectangle.Width;
                    }
                    break;
                case Huong.PHAI: pic.Left += 5;
                    if(pic.Left >= ClientRectangle.Width)
                    {
                        pic.Left = -pic.Width;
                    }
                    break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture|*.png" +
                "|Gif|*.gif" +
                "|Jpeg|*.jpeg" +
                "|Jpg|*.jpg";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            pic.Image = Image.FromFile(ofd.FileName);
        }
    }
}
