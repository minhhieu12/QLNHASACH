using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaSach.Class;

namespace QLNhaSach
{
    public partial class Login : Form
    {
        frmMain fmain = null;
        XLNHANVIEN tblNhanVien;
        public Login(frmMain pf)
        {
            fmain = pf;
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DataRow[] r = tblNhanVien.Select("Username='" + txtUserName.Text + "' and Password ='" + txtPassword.Text + "'");
            if(r.Count()>0)
            {
                fmain.Text = "Quản lý nhà sách - Chào " + r[0]["TenNV"].ToString();
                fmain.maNV = r[0]["MaNV"].ToString();
                fmain.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tà khoản và mật khẩu");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
