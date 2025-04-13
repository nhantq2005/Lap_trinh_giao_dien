using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ON_TAP.DrawShape
{
    public partial class FrmMain : Form
    {
        public enum ShapeType
        {
            Triangle,
            Rectangle,
            Line,
            Ellipse
        }
        public FrmMain()
        {
            InitializeComponent();
        }
    }
}
