using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MoveObject
{
    public partial class Form1 : Form
    {
        string[] arrFile;
        string path;
        Point pOld;
        Random rnd = new Random();
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrFile = Directory.GetFiles(Application.StartupPath + @"\Images\");
            AddNewPic();
        }

        public void AddNewPic()
        {
            cnt++;
            int idx = rnd.Next(arrFile.Length);
            Image img = Image.FromFile(arrFile[idx]);
            PictureBox pic = new PictureBox();
            pic.Image = img;
            pic.Name = cnt.ToString();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Width = pic.Height = 150;
            //SỰ KIỆN CHUỘT
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;
            pic.MouseDown += Pic_MouseDown;
            this.Controls.Add(pic);
            this.Controls.SetChildIndex(pic, 0);
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (listImg.Bounds.Contains(pic.Bounds))
            {
                listImg.Controls.Add(pic);
                AddNewPic();
            }
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int dx= e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arr = this.Controls.Find(cnt.ToString(), false);
            PictureBox picture = (PictureBox)arr[0];
            switch (e.KeyCode)
            {
                case Keys.Up: picture.Top -= 10;break;
                case Keys.Down: picture.Top += 10; break;
                case Keys.Right: picture.Left += 10; break;
                case Keys.Left: picture.Left -= 10; break;
            }
        }

        private void listImg_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void listImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FlowLayoutPanel p = (FlowLayoutPanel)sender;
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                p.Left += dx;
                p.Top += dy;
            }
        }
    }
}
