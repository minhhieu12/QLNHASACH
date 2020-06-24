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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, "");
            errorProvider1.SetError(txtConfirmPass, "");

            if(txtPassNew.Text.Length<8 || !txtPassNew.Text.Any(char.IsDigit) || !txtPassNew.Text.Any(char.IsLower) || !txtPassNew.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtPassNew, "Mật khẩu mới bao gồm ít nhất 8 kí tự, gồm chữ in hoa, in thường, số");
                return;
            }

            if (txtPassNew.Text != txtConfirmPass.Text)
            {
                errorProvider1.SetError(txtConfirmPass, "Nhập lại mật khẩu không đúng!");
                return;
            }

            frmMain f = (frmMain)this.MdiParent;
            int count = XLBANG.Thuc_hien_lenh("UPDATE NHANVIEN SET Password = '" + txtPassNew.Text + "' WHERE MaNV = '" + f.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
            } 
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
            }
        }
    }
}
