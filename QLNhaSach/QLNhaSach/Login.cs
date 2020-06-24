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
        }
    }
}
