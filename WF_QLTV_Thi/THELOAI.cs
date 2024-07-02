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
	public partial class THELOAI : Form
	{
		BLL_THELOAI tl = new BLL_THELOAI();
		int j;
		public THELOAI()
		{
			InitializeComponent();
		}

		private string sinhmatudong(int j)
		{

			if (j <= 9)
			{
				return "TL00" + j;
			}
			else
			{
				return "Tl0" + j;
			}

		}
		private void hienthima()
		{
			j = dataGV_TheLoai.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (dataGV_TheLoai.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txb_MaTL.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txb_MaTL.Text = sinhmatudong(j);
		}


		private void btn_Xem_Click(object sender, EventArgs e)
		{
			dataGV_TheLoai.DataSource = tl.TL_select();
			txb_TenTL.Clear();
			hienthima();
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			try
			{
				tl.TL_insert(txb_MaTL.Text, txb_TenTL.Text);
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
			tl.TL_update(txb_MaTL.Text, txb_TenTL.Text);
			btn_Xem_Click(sender, e);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			tl.TL_delete(txb_MaTL.Text);
			btn_Xem_Click(sender, e);
		}

		private void dataGV_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGV_TheLoai.Rows[e.RowIndex];
				txb_MaTL.Text = row.Cells[0].Value.ToString();
				txb_TenTL.Text = row.Cells[1].Value.ToString();
		
			}
		}
	}
}
