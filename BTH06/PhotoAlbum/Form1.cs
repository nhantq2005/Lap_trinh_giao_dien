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

        private void treeFolder_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
    }
}
