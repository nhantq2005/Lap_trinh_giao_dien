using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xucxac
{
    public partial class Form1 : Form
    {
        int guess=1;
        Random r = new Random();
        int doan = 0, thang = 0, thua = 0;
        string imgPath;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            imgPath = Application.StartupPath + @"\";
        }

        private void taoSoNgauNhien()
        {
            doan++;
            int rNum = r.Next(1, 7);
         
            diceResult.Image = Image.FromFile(imgPath+rNum+".png");
            if (guess == rNum)
            {
                thang++;
                history.Items.Add(String.Format("{0}. Thắng (Đoán {1} ra {2})", this.doan, this.guess, rNum));

            }
            else
            {
                thua++;
                history.Items.Add(String.Format("{0}. Thua (Đoán {1} ra {2})", this.doan, this.guess, rNum));

            }
            doanlb.Text = String.Format("Lần đoán: {0}", this.doan);
            thanglb.Text = String.Format("Lần thắng: {0} ({1:F2}%)", this.thang, this.thang * 100.0 / this.doan);
            thualb.Text = String.Format("Lần thua: {0} ({1:F2}%)", this.thua, this.thua * 100.0 / this.doan);
        }

        private void khoiPhuc()
        {
            history.Items.Clear();
            this.doan = 0; this.thang = 0;this.thua = 0;
            doanlb.Text = String.Format("Lần đoán: {0}", this.doan);
            thanglb.Text = String.Format("Lần thắng: {0} ({1:F2}%)", this.thang,0);
            thualb.Text = String.Format("Lần thua: {0} ({1:F2}%)", this.thua, 0);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            khoiPhuc();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter) taoSoNgauNhien();
            if (keyData == Keys.Escape) khoiPhuc();
            return base.ProcessDialogKey(keyData);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            diceGuess.Image = Image.FromFile(imgPath+guess+".png");
            guess = int.Parse(bt.Text);
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            taoSoNgauNhien();
        }
    }
}
