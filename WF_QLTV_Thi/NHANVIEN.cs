using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLTV_Thi
{
	public partial class NHANVIEN : Form
	{
		BLL_NHANVIEN nv=new BLL_NHANVIEN();
		BLL_CHUCVU cv =new BLL_CHUCVU();
		int j;
		public NHANVIEN()
		{
			InitializeComponent();
		}
		private void NHANVIEN_Load(object sender, EventArgs e)
		{

		}

		private string sinhmatudong(int j)
		{

			if (j <= 9)
			{
				return "NV00" + j;
			}
			else
			{
				return "NV0" + j;
			}

		}
		private void hienthima()
		{
			j = dataGV_NhanVien.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (dataGV_NhanVien.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txb_MaNV.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txb_MaNV.Text = sinhmatudong(j);
		}
		private void btn_Xem_Click(object sender, EventArgs e)
		{
			dataGV_NhanVien.DataSource = nv.NV_select_all();
			hienthima();
	
			cbb_MaCV.DataSource = cv.CV_select_all();
			cbb_MaCV.DisplayMember = "TenCV";
			cbb_MaCV.ValueMember = "MaCV";
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			try
			{
				nv.NV_insert(txb_MaNV.Text, txb_TenNV.Text,cbb_MaCV.SelectedValue.ToString(), dt_NgaySinh.Value,cbb_gioitinh.Text, txb_sdt.Text, txb_taikhoan.Text, txb_matkhau.Text);
				btn_Xem_Click(sender, e);
			}
			catch (SqlException ex)
			{
				foreach (SqlError error in ex.Errors)
				{
					if (error.Number == 2627) // Mã lỗi 2627 là lỗi khóa chính không được trùng
					{
						MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				// Nếu không phải là lỗi khóa chính không được trùng, hiển thị thông báo lỗi mặc định
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			nv.NV_update(txb_MaNV.Text, txb_TenNV.Text, cbb_MaCV.SelectedValue.ToString(), dt_NgaySinh.Value, cbb_gioitinh.Text, txb_sdt.Text, txb_taikhoan.Text, txb_matkhau.Text);
			btn_Xem_Click(sender, e);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			nv.NV_delete(txb_MaNV.Text);
			btn_Xem_Click(sender, e);
		}

		private void dataGV_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGV_NhanVien.Rows[e.RowIndex];
				txb_MaNV.Text = row.Cells[0].Value.ToString();
				txb_TenNV.Text = row.Cells[1].Value.ToString();
				cbb_MaCV.Text = row.Cells[2].Value.ToString();
				dt_NgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value);
				cbb_gioitinh.Text = row.Cells[4].Value.ToString();
				txb_sdt.Text = row.Cells[5].Value.ToString();
				txb_taikhoan.Text = row.Cells[6].Value.ToString();
				txb_matkhau.Text = row.Cells[7].Value.ToString();
			}
		}

	
	}
}
