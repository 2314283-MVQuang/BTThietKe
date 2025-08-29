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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            int so;
            Random ran = new Random();
            for(int i = 0; i < 10; i++)
            {
               so = ran.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int timSo = int.Parse(txtSoCanTim.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach (int so in listBox1.Items)
            {
                if (so == timSo)
                {
                    lblKetQua.Text = "Tìm Thấy";
                    break;
                }

            }
        }
    }
}
