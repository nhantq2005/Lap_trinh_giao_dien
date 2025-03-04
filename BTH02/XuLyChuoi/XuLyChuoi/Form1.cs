using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyChuoi
{
    public partial class Form1 : Form
    {
        string s = "khoa  Công nGhệ thông tiN,  Trường Đại học mở tp Hồ chí Minh";
        public Form1()
        {
            InitializeComponent();
            s1.Text = s;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            s1.Text = s;
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(posIns.Text);
                s1.Text = s.Insert(index, s2.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void getStrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int startIdx = int.Parse(posGet.Text);
                int len = int.Parse(numChar.Text);
                string strVal = s1.Text;
                string subStr = strVal.Substring(startIdx, len);
                s2.Text = subStr;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void convBtn_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = s1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();

            }
            s1.Text = String.Join(" ", arr);
        }

        private void revBtn_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = s1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            s1.Text = String.Join(" ", arr);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            title.Text = title.Text.Substring(title.Text.Length - 1) +
                title.Text.Substring(0, title.Text.Length - 1);
        }

        private void rpBtn_Click(object sender, EventArgs e)
        {
            string s1Val = s1.Text.ToLower();
            string s2Val = s2.Text.ToLower();
            int idx = s1Val.IndexOf(s2Val);
            while (idx >= 0)
            {
                s1Val = s1Val.Remove(idx, s2Val.Length);
                s1Val = s1Val.Insert(idx, s3.Text);
                s1.Text = s1.Text.Remove(idx, s2Val.Length);
                s1.Text = s1.Text.Insert(idx, s3.Text);
                idx = s1Val.IndexOf(s2Val);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string s1Val = s1.Text.ToLower();
            string s2Val = s2.Text.ToLower();
            int idx = s1Val.IndexOf(s2Val);
            while (idx >= 0)
            {
                s1Val = s1Val.Remove(idx, s2Val.Length);
                s1.Text = s1.Text.Remove(idx, s2Val.Length);
                idx = s1Val.IndexOf(s2Val);
            }
        }
    }
}
