using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DE_MAU_04
{
    public partial class FrmDelay : Form
    {
        int cnt=10;
        private Timer countdownTimer;
        public FrmDelay()
        {
            InitializeComponent();
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 giây
            countdownTimer.Tick += timer1_Tick;
        }

        private void FrmDelay_Paint(object sender, PaintEventArgs e)
        {
            Font fontHead = new Font("Arial", 40, FontStyle.Italic);
            
            HatchBrush hbr = new HatchBrush(HatchStyle.LargeGrid,Color.Yellow,Color.GreenYellow);
           
            LinearGradientBrush lbr = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow, 45);

            StringFormat fHead = new StringFormat();


            fHead.Alignment = StringAlignment.Center;
            fHead.LineAlignment = StringAlignment.Center;
        

            e.Graphics.FillRectangle(lbr, ClientRectangle);
            e.Graphics.DrawString("2351050121_TranQuocNhan",fontHead,hbr,ClientRectangle,fHead);
            Font fontTitle = new Font("Arial", 30, FontStyle.Regular);
            SolidBrush br = new SolidBrush(Color.Purple);
            StringFormat fTitle = new StringFormat();
            fTitle.Alignment = StringAlignment.Center;
            fTitle.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString(cnt.ToString(), fontTitle, br, ClientRectangle, fTitle);


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            cnt--;
            if (cnt < 0)
            {

                this.Close();
            }

        }
    }
}
