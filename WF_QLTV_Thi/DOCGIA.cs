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
	public partial class DOCGIA : Form
	{
		BLL_DOCGIA dg = new BLL_DOCGIA();

		int j;
		public DOCGIA()
		{
			InitializeComponent();
		}

		private void DOCGIA_Load(object sender, EventArgs e)
		{

		}
		private string sinhmatudong(int j)
		{



			if (j <= 9)
			{
				return "DG00" + j;
			}
			else
			{
				return "DG0" + j;
			}

		}
		private void hienthima()
		{
			j = dataGV_DocGia.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (dataGV_DocGia.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txb_MaDG.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txb_MaDG.Text = sinhmatudong(j);
		}
		private void btn_Xem_Click(object sender, EventArgs e)
		{
			dataGV_DocGia.DataSource = dg.DG_select_all();
			hienthima();
			txb_TenDG.Clear();
			txb_diachi.Clear();
			txb_sdt.Clear();
		
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			try
			{
				dg.DG_insert(txb_MaDG.Text, txb_TenDG.Text, dt_NgaySinh.Value, cbb_gioitinh.Text, cbb_loaiDG.Text, txb_diachi.Text, txb_sdt.Text);
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
			dg.DG_update(txb_MaDG.Text, txb_TenDG.Text, dt_NgaySinh.Value, cbb_gioitinh.Text, cbb_loaiDG.Text, txb_diachi.Text, txb_sdt.Text);
			btn_Xem_Click(sender, e);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			dg.DG_delete(txb_MaDG.Text);
			btn_Xem_Click(sender, e);
		}

		private void dataGV_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGV_DocGia.Rows[e.RowIndex];
				txb_MaDG.Text = row.Cells[0].Value.ToString();
				txb_TenDG.Text = row.Cells[1].Value.ToString();
				dt_NgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value);
				cbb_gioitinh.Text = row.Cells[3].Value.ToString();
				cbb_loaiDG.Text = row.Cells[4].Value.ToString();
				txb_diachi.Text = row.Cells[5].Value.ToString();
				txb_sdt.Text = row.Cells[6].Value.ToString();
			}

		}

	
	}
}
