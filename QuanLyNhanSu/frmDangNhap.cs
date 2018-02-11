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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private bool check()
        {
            if (string.IsNullOrWhiteSpace(txbUserName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUserName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPassword.Focus();
                return false;
            }
            return true;
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (txbUserName.Text.Equals("admin") && txbPassword.Text.Equals("admin"))
                {
                    this.Hide();
                }
                else
                {
                        lblNote.Visible = true;
                        lblNote.Text = "Ban da nhap sai ten hoac mat khau";
                    
                }
            }
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }
    }
}
