﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindownForms
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            frmBai1 frmBai1 = new frmBai1();
            frmBai1.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            frmBai2 frmBai2 = new frmBai2();
            frmBai2.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            frmBai3 frmBai3 = new frmBai3();
            frmBai3.ShowDialog();
        }
    }
}
