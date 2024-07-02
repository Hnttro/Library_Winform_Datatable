using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTV_Thi
{
	public partial class PHIEUMUON_TRASACH : Form
	{

		BLL_SACH s = new BLL_SACH();
		BLL_DOCGIA dg = new BLL_DOCGIA();
		BLL_NHANVIEN nv = new BLL_NHANVIEN();
		BLL_PHIEUMUON pm = new BLL_PHIEUMUON();
		BLL_CHITIETPHIEUMUON ctpm = new BLL_CHITIETPHIEUMUON();
		int j;
		DataTable dt;
		public PHIEUMUON_TRASACH()
		{
			InitializeComponent();
		}

		private void PHIEUMUON_TRASACH_Load(object sender, EventArgs e)
		{
            cbb_NV.DataSource = nv.NV_select_all();
            cbb_NV.DisplayMember = "TenNV";
            cbb_NV.ValueMember = "MaNV";
            cbb_DG.DataSource = dg.DG_select_all();
            cbb_DG.DisplayMember = "TenDG";
            cbb_DG.ValueMember = "MaDG";
            cbb_MaS.DataSource = s.Sach_select_all();
            cbb_MaS.DisplayMember = "TenSach";
            cbb_MaS.ValueMember = "MaSach";
            cbb_MaS_SelectedIndexChanged(sender, e);
            btnShow.PerformClick();
        }
        private void cbb_MaS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowindex = cbb_MaS.SelectedIndex;
           
            txb_TenS.Text = s.Sach_select_all().Rows[rowindex][1].ToString();
            txb_TinhTrang.Text = s.Sach_select_all().Rows[rowindex][8].ToString();
        }

        private string sinhmatudong(int j)
		{
			if (j <= 9)
			{
				return "MP00" + j;
			}
			else
			{
				return "MP0" + j;
			}
		}
		private void hienthima()
		{
			j = DaTaGV_PM.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (DaTaGV_PM.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txt_MaPM.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txt_MaPM.Text = sinhmatudong(j);
			
		}

   

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pm.PM_insert(txt_MaPM.Text, cbb_NV.SelectedValue.ToString(), cbb_DG.SelectedValue.ToString(),
               NgayMuon.Value, NgayTra.Value, txb_ghichu.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataGridViewRow selectedRow = DaTaGV_CTPM.Rows[i];
                ctpm.CT_PM_insert(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString(), int.Parse(selectedRow.Cells[3].Value.ToString()), selectedRow.Cells[4].Value.ToString());
            }
            btnShow.PerformClick();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DaTaGV_PM.DataSource = pm.PM_select_all();
           
            hienthima();
            dt = new DataTable();
            dt.Columns.Add("MaSach", typeof(string));
            dt.Columns.Add("MaPhieu", typeof(string));
            dt.Columns.Add("TenSach", typeof(string));
            dt.Columns.Add("SL", typeof(int));
            dt.Columns.Add("TinhTrang", typeof(string));
            DaTaGV_CTPM.DataSource = dt;
            //txtDiaChi.Clear();
            //txtSearch.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pm.PM_update(txt_MaPM.Text, cbb_NV.SelectedValue.ToString(), cbb_DG.SelectedValue.ToString(),
               NgayMuon.Value, NgayTra.Value, txb_ghichu.Text);
            btnShow.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pm.PM_delete(txt_MaPM.Text);
            btnShow.PerformClick();
        }
        private void showCTHD(string MaPM)
        {
            //dt = CTHD.ChiTietHoaDon_Select_Where(MaHD);
            //dt.Columns.Add("Đơn vị tính",typeof(string));
            //dt.Columns.Add("Đơn giá", typeof(string));
            DaTaGV_CTPM.DataSource = ctpm.CT_PM_select_W(MaPM);
            
        }
        private void DaTaGV_PM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DaTaGV_PM.Rows[e.RowIndex];
                txt_MaPM.Text = row.Cells[0].Value.ToString();
                cbb_NV.SelectedValue = row.Cells[1].Value.ToString();
                cbb_DG.SelectedValue = row.Cells[2].Value.ToString();
                NgayMuon.Value = Convert.ToDateTime(row.Cells[3].Value);
                NgayTra.Value = Convert.ToDateTime(row.Cells[4].Value);
                txb_ghichu.Text = row.Cells[5].Value.ToString();



                showCTHD(txt_MaPM.Text);
               
            }
           
        }
        private void btnCTPMinsert_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(cbb_MaS.SelectedValue.ToString(), txt_MaPM.Text,  txb_TenS.Text, int.Parse(txb_Soluong.Text), txb_TinhTrang.Text);
        }

        private void btnCTPMupdate_Click(object sender, EventArgs e)
        {
            ctpm.CT_PM_update(cbb_MaS.SelectedValue.ToString(), txt_MaPM.Text, txb_TenS.Text, int.Parse(txb_Soluong.Text), txb_TinhTrang.Text);
        }

        private void btnCTPMdelete_Click(object sender, EventArgs e)
        {
            ctpm.CT_PM_delete(cbb_MaS.Text, txt_MaPM.Text);
        }

        private void DaTaGV_CTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            // Lấy giá trị của ô dữ liệu được chọn  // Hiển thị giá trị của ô dữ liệu được chọn trong các Textbox
            DataGridViewRow selectedRow = DaTaGV_CTPM.Rows[rowIndex];
            cbb_MaS.Text = selectedRow.Cells[1].Value.ToString();
            txt_MaPM.Text = selectedRow.Cells[0].Value.ToString();
            txb_TenS.Text = selectedRow.Cells[2].Value.ToString();
            txb_Soluong.Text = selectedRow.Cells[3].Value.ToString();
            txb_TinhTrang.Text = selectedRow.Cells[4].Value.ToString();
        }
    
    }
}
