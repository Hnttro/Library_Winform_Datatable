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
	public partial class SACH : Form
	{
		BLL_SACH s = new BLL_SACH();
		BLL_TACGIA tg = new BLL_TACGIA();
		BLL_THELOAI tl = new BLL_THELOAI();
		int j;
		public SACH()
		{
			InitializeComponent();
		}
		private void SACH_Load(object sender, EventArgs e)
		{

			cbb();
		}
		private string sinhmatudong(int j)
		{

			if (j <= 9)
			{
				return "MS00" + j;
			}
			else
			{
				return "MS0" + j;
			}

		}
		private void hienthima()
		{
			j = dataGV_Sach.Rows.Count;
			bool check = false;
			for (int i = 0; i < j; i++)
			{
				if (i != (j - 1))
					if (dataGV_Sach.Rows[i].Cells[0].Value.ToString() != sinhmatudong(i + 1))
					{
						txb_MaS.Text = sinhmatudong(i + 1);
						check = true;
						break;
					}
			}
			if (check == false)
				txb_MaS.Text = sinhmatudong(j);
		}
		void cbb()
		{
			cbb_TheLoai.DataSource = tl.TL_select();
			cbb_TheLoai.DisplayMember ="TenTheLoai";
			cbb_TheLoai.ValueMember ="MaTheLoai";

			cbb_TacGia.DataSource = tg.TG_select();
			cbb_TacGia.DisplayMember ="TenTacGia";
			cbb_TacGia.ValueMember ="MaTacGia";
		}
		private void btn_Xem_Click(object sender, EventArgs e)
		{
			dataGV_Sach.DataSource = s.Sach_select_all();
			hienthima();
			txb_TenS.Clear();
			txb_nhaXB.Clear();
			txb_namXB.Clear();
			txb_dongia.Clear();
			txb_tinhtrang.Clear();

		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			try
			{
				s.Sach_insert(txb_MaS.Text, txb_TenS.Text, cbb_TheLoai.SelectedValue.ToString(), cbb_TacGia.SelectedValue.ToString(), txb_nhaXB.Text
					,txb_namXB.Text, (int)nd_sl.Value, int.Parse(txb_dongia.Text), txb_tinhtrang.Text);
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

			s.Sach_update(txb_MaS.Text, txb_TenS.Text, cbb_TheLoai.SelectedValue.ToString(), cbb_TacGia.SelectedValue.ToString(), txb_nhaXB.Text
					, txb_namXB.Text, (int)nd_sl.Value, int.Parse(txb_dongia.Text), txb_tinhtrang.Text);
			btn_Xem_Click(sender, e);
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			s.Sach_delete(txb_MaS.Text);
			btn_Xem_Click(sender, e);
		}

		private void dataGV_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGV_Sach.Rows[e.RowIndex];
				txb_MaS.Text = row.Cells["MaSach"].Value.ToString();
				txb_TenS.Text = row.Cells["TenSach"].Value.ToString();
				cbb_TheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
				cbb_TacGia.Text = row.Cells["MaTacGia"].Value.ToString();
				txb_nhaXB.Text = row.Cells["NhaXB"].Value.ToString();
				txb_namXB.Text = row.Cells["NamXB"].Value.ToString();
				nd_sl.Value = Convert.ToInt32(row.Cells["SL"].Value);
				txb_dongia.Text = row.Cells["DonGia"].Value.ToString();
				txb_tinhtrang.Text = row.Cells["TinhTrang"].Value.ToString();
			}
		}

	
	}
	
}
