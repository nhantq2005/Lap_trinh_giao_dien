using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Xceed.Words.NET;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "new form";
            f.BackColor = Color.Red;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //private string ReadWordFile(string filePath)
        //{
        //    // Method 1: Using Microsoft.Office.Interop.Word (requires Word installed)
        //    if (rbUseInterop.Checked)
        //        return ReadWordFileUsingInterop(filePath);

        //    // Method 2: Using DocX library (no Word installation required)
           
        //}

        private string ReadWordFileUsingInterop(string filePath)
        {
            Microsoft.Office.Interop.Word.Application wordApp = null;
            Microsoft.Office.Interop.Word.Document wordDoc = null;

            try
            {
                // Create Word application instance
                wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false;

                // Open document
                wordDoc = wordApp.Documents.Open(filePath, ReadOnly: true);

                // Extract text
                string content = wordDoc.Content.Text;

                return content;
            }
            finally
            {
                //// Clean up COM objects
                //if (wordDoc != null)
                //{
                //    wordDoc.Close(false);
                //    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                //}

                //if (wordApp != null)
                //{
                //    wordApp.Quit();
                //    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                //}

                //GC.Collect();
                //GC.WaitForPendingFinalizers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Nhận file txt
            ofd.Filter = "Document File(*.docx)|*.docx|Text File(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label1.Text=ReadWordFileUsingInterop (ofd.FileName);
                label2.Text=ofd.FileName;
            }

        }
    }
}
