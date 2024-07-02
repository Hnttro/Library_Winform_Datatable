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
	public partial class TACGIA : Form
	{
		BLL_TACGIA tg = new BLL_TACGIA();
		int j;
		public TACGIA()
		{
			InitializeComponent();
		}

		private string sinhmatudong(int j)
		{

			if (j <= 9)
			{
				return "TG00" + j;
			}
			else
			{
				return "TG0" + j;
			}

		}
		private void hienthima()
		{
			j = dataGV_TacGia.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (dataGV_TacGia.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txb_MaTG.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txb_MaTG.Text = sinhmatudong(j);
		}
		private void btn_Xem_Click(object sender, EventArgs e)
		{
			dataGV_TacGia.DataSource = tg.TG_select();
			txb_TenTG.Clear();
			txb_quocgia.Clear();
			hienthima();
			

		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			try { 
			tg.TG_insert(txb_MaTG.Text, txb_TenTG.Text,dt_NgaySinh.Value,txb_quocgia.Text);
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
			tg.TG_update(txb_MaTG.Text, txb_TenTG.Text, dt_NgaySinh.Value, txb_quocgia.Text);
			btn_Xem_Click(sender, e);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			tg.TG_delete(txb_MaTG.Text);
			btn_Xem_Click(sender, e);
		}

		private void dataGV_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGV_TacGia.Rows[e.RowIndex];
				txb_MaTG.Text = row.Cells[0].Value.ToString();
				txb_TenTG.Text = row.Cells[1].Value.ToString();
				dt_NgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value);
				txb_quocgia.Text = row.Cells[3].Value.ToString();
			}
		}
	}
}
