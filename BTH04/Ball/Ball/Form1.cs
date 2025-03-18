using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class Form1 : Form
    {
        int dx = 5, dy = 5;

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0 || ball.Right > ClientRectangle.Width)
                    dx = -dx;
            if (ball.Top < 0 || ball.Bottom > ClientRectangle.Height)
                dy = -dy;
            ball.Left += dx;
            ball.Top += dy;
        }
    }
}
