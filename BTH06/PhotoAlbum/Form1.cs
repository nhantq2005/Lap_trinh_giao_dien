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

namespace PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (var item in drives)
            {
                node = new TreeNode(item);
                treeFolder.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            try
            {
                foreach(string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("temp");
                }
            }
            catch { }
        }

        //private void treeFolder_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        //{
        //    e.Node.ImageIndex = 0;
        //}

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Img.Image = null;
                string[] arrFiles = Directory.GetFiles(e.Node.FullPath);
                listImg.Controls.Clear();
                foreach (string file in arrFiles)
                {
                    if(file.ToLower().EndsWith(".jpg")||
                        file.ToLower().EndsWith(".jpeg") ||
                        file.ToLower().EndsWith(".png") ||
                        file.ToLower().EndsWith(".gif") ||
                        file.ToLower().EndsWith(".bmp"))
                    {
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(file);
                        pic.Height = listImg.Height - 10;
                        pic.Width = pic.Height * 5 / 4;
                        pic.Cursor = Cursors.Hand;
                        listImg.Controls.Add(pic);
                        pic.Click += new EventHandler(PictureBox_Click);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Img.Image = pic.Image;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void treeFolder_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                e.Node.SelectedImageIndex = 1;
            }
        }

        private void treeFolder_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                e.Node.SelectedImageIndex = 0;
            }
        }
    }
}
