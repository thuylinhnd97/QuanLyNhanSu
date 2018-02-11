using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MnuThemNV_Click(object sender, EventArgs e)
        {
            frmQLNhanvien frm = new frmQLNhanvien();
            frm.ShowDialog();
        }

        private void MnuThemPB_Click(object sender, EventArgs e)
        {
            frmQLPhongBan frm = new frmQLPhongBan();
            frm.ShowDialog();
        }

        private void MnuThemDA_Click(object sender, EventArgs e)
        {
            frmQLDuAn frm = new frmQLDuAn();
            frm.ShowDialog();
        }
    }
}
