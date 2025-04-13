using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_MAU_04
{
    enum Direct
    {
        LEFT,RIGHT, UP, DOWN
    }
    public partial class FrmMain : Form
    {
        Direct direct;
        public FrmMain()
        {
            FrmDelay frmDelay = new FrmDelay();
            frmDelay.ShowDialog();
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            direct = Direct.LEFT;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: direct= Direct.UP; break;
                case Keys.Down: direct= Direct.DOWN; break;
                case Keys.Left: direct= Direct.LEFT; break;
                case Keys.Right: direct= Direct.RIGHT; break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(direct)
            {
                case Direct.LEFT: pic.Left -= 5;
                    if(pic.Right<=0)
                    {
                        pic.Left = ClientRectangle.Width;
                    }
                    break;
                case Direct.RIGHT: pic.Left += 5;
                    if(pic.Left>ClientRectangle.Width) 
                    {
                        pic.Left=-pic.Width;
                    }
                    break;
                case Direct.UP: pic.Top -= 5;
                    if (pic.Bottom <= 0)
                    {
                        pic.Top = ClientRectangle.Height;
                    }
                    break;
                case Direct.DOWN: pic.Top += 5;
                    if (pic.Top >= ClientRectangle.Height)
                    {
                        pic.Top = -pic.Height;
                    }
                    break;
            }
        }
    }
}
