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
using System.Data.SqlClient;

namespace QLNhaSach
{
    public partial class ChamCong : Form
    {
        XLNHANVIEN tblNhanVien;
        XLCHAMCONG tblChamCong;
        public ChamCong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                if (e.ColumnIndex == 5)
                    tblChamCong.Rows[e.RowIndex].Delete();
                tblChamCong.ghi();
            }
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            tblChamCong = new XLCHAMCONG();
            loadCTChamCong();
            loadNhanVien();
            dtNgay.Value = DateTime.Now;
        }

        private void loadNhanVien()
        {
            listNhanVien.DataSource = tblNhanVien;
            listNhanVien.ValueMember = "MaNV";
            listNhanVien.DisplayMember = "TenNV";
        }

        private void loadCTChamCong()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNhanVien, tblChamCong });
            DataRelation qh = new DataRelation("FRK_NHANVIEN_CHAMCONG", tblNhanVien.Columns["MaNV"], tblChamCong.Columns["MaNV"]);
            ds.Relations.Add(qh);
            DataColumn cTenNV = new DataColumn("TenNV", Type.GetType("System.String"), "Parent(FRK_NHANVIEN_CHAMCONG).TenNV");
            tblChamCong.Columns.Add(cTenNV);
            dgvCTChamCong.AutoGenerateColumns = false;
            dgvCTChamCong.DataSource = tblChamCong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow r = tblChamCong.NewRow();
            r["MaNV"] = listNhanVien.SelectedValue;
            r["Ngay"] = dtNgay.Value.ToShortDateString();
            r["SoGio"] = numSoGio.Value;
            tblChamCong.Rows.Add(r);
            tblChamCong.ghi();
        }

        private void dtNgay_ValueChanged(object sender, EventArgs e)
        {
            tblChamCong.locDuLieu("Ngay = '" + dtNgay.Value.ToShortDateString() + "'");

        }

        private void dgvCTChamCong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTChamCong.Rows)
                r.Cells[0].Value = r.Index + 1;
        }


    }
}
