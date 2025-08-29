using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTThietKe
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            frmBai1 frmBai1 = new frmBai1();
            frmBai1.ShowDialog();   
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            frmBai2 frmBai2 = new frmBai2();
            frmBai2.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            frmbai3 frmBai3 = new frmbai3();
            frmBai3.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 frmBai4 = new frmBai4();
            frmBai4.ShowDialog();
        }
    }
}
