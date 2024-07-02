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
	public partial class CHUCVU : Form
	{
		BLL_CHUCVU cv = new BLL_CHUCVU();
		int j;
		public CHUCVU()
		{
			InitializeComponent();
		}
		private string sinhmatudong(int j)
		{

			if (j <= 9)
			{
				return "CV00" + j;
			}
			else
			{
				return "CV0" + j;
			}

		}
		private void hienthima()
		{
			j = dataGV_CHUCVU.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (dataGV_CHUCVU.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txb_MaCV.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txb_MaCV.Text = sinhmatudong(j);
		}
		private void btn_Xem_Click(object sender, EventArgs e)
		{
			dataGV_CHUCVU.DataSource = cv.CV_select_all();
			txb_TenCV.Clear();
			txb_ghichu.Clear();
			hienthima();

		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			try
			{
				cv.CV_insert(txb_MaCV.Text, txb_TenCV.Text, txb_ghichu.Text);
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
			cv.CV_update(txb_MaCV.Text, txb_TenCV.Text, txb_ghichu.Text);
			btn_Xem_Click(sender, e);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			cv.CV_delete(txb_MaCV.Text);
			btn_Xem_Click(sender, e);
		}

		private void dataGV_CHUCVU_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGV_CHUCVU.Rows[e.RowIndex];
				txb_MaCV.Text = row.Cells[0].Value.ToString();
				txb_TenCV.Text = row.Cells[1].Value.ToString();
				txb_ghichu.Text = row.Cells[2].Value.ToString();
			}
		}
	}
}
