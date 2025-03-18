using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapXepMang
{
    public partial class Form1 : Form
    {
        List<int> a = new List<int>();
        Random rnd = new Random();
        int mid;
        public Form1()
        {
            InitializeComponent();
        }


        private void oddEven()
        {
            int i = 0,j=a.Count-1;
            while (i < j)
            {
                if (a[i] %2== 0) i++;
                if (a[j] %2==1) j--;
                if (a[i] % 2 == 1 && a[j] % 2 == 0)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            if (a.Count % 2 == 1)
            {
                mid = i;
            }
            else
            {
                mid = i - 1;
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                arr.Text="";
                a.Clear();
                for (int i = 0; i < int.Parse(sizeArr.Text); i++)
                {
                    a.Add(rnd.Next(100));
                }
                arr.Text = String.Join(",", a.ToArray());   
            }
            catch(FormatException) { 
                MessageBox.Show("VUI LÒNG NHẬP SỐ PHẦN TỬ","CẢNH BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            //Shallow copy
            List<int> sortList = a.ToList<int>();
            sortList.Sort();
            inscArr.Text= String.Join(",", sortList.ToArray());
            sortList.Reverse();
            descArr.Text = String.Join(",", sortList.ToArray());
            a.Reverse();
            revArr.Text = String.Join(",", a.ToArray());
            this.oddEven();
            List<int> subEvenList = a.GetRange(0,mid);
            List<int> subOddList = a.GetRange(mid+1,a.Count-2);
            subEvenList.Sort();
            subOddList.Sort();
            subOddList.Reverse();
            subEvenList.AddRange(subOddList);
            oddEvenArr.Text= String.Join(",", subEvenList.ToArray());
        }
    }
}
