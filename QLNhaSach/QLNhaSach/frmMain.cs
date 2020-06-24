using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string maNV;
        ChangePassword fDoiMatKhau;
        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            Login f = new Login();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void enableControl(int maLTK)
        {
            switch (maLTK)
            {
                case 1:
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
                case 2:
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = false;
                    btnSanPham.Enabled = false;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = false;
                    break;
                case 3:
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = false;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnTaoHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
                default:
                    btnDangXuat.Enabled = false;
                    btnDoiMK.Enabled = false;
                    btnNhanVien.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = false;
                    btnKhachHang.Enabled = false;
                    btnTaoHoaDon.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
            }
        }

        private void btnChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            frmMain_Load(sender, e);
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fDoiMatKhau == null)
            {
                fDoiMatKhau = new ChangePassword();
                fDoiMatKhau.MdiParent = this;
                fDoiMatKhau.WindowState = FormWindowState.Maximized;
                fDoiMatKhau.Show();
            }

            else
            {
                fDoiMatKhau.Activate();
                fDoiMatKhau.Show();
            }
        }
    }
}
