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
	public partial class Form1 : Form
	{
		bool sidebarExpand;
        bool bookcool;
        private string tenNhanVien;

        CHUCVU cv = new CHUCVU();
        NHANVIEN nv = new NHANVIEN();
        PHIEUMUON_TRASACH pm = new PHIEUMUON_TRASACH();
        DOCGIA dg = new DOCGIA();
        SACH s = new SACH();
        TACGIA tg= new TACGIA();
        THELOAI tl= new THELOAI();



        public Form1(string tenNhanVien)
		{
			InitializeComponent();
            this.tenNhanVien = tenNhanVien;
            // Cập nhật thanh menu với tên nhân viên
            //menuStrip1.Items["tToolStripMenuItem"].Text = "Nhân viên: " + tenNhanVien;
            TenNVHienThi.Text = "Nhân viên: " + tenNhanVien;
        }

        // chỉnh thanh cuộn
        private void sidebarTick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                // If sidebar is minimized, expand
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void BookTime_Tick(object sender, EventArgs e)
        {
            if (bookcool)
            {
                BookContaner.Height += 10;
                if (BookContaner.Height == BookContaner.MaximumSize.Height)
                {
                    bookcool = false;
                    BookTime.Stop();
                }
            }
            else
            {
                BookContaner.Height -= 10;
                // If sidebar is minimized, expand
                if (BookContaner.Height == BookContaner.MinimumSize.Height)
                {
                    bookcool = true;
                    BookTime.Stop();
                }
            }
        }

        private void btn_QuanLySach_Click(object sender, EventArgs e)
        {
            BookTime.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sach_Click(object sender, EventArgs e)
        {
            s.ShowDialog();
        }

        private void btn_TacGia_Click(object sender, EventArgs e)
        {
            tg.ShowDialog();
        }

        private void btn_TheLoai_Click(object sender, EventArgs e)
        {
            tl.ShowDialog();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            nv.ShowDialog();
        }

        private void btn_DocGia_Click(object sender, EventArgs e)
        {
            dg.ShowDialog();
        }

        private void btn_MuonTraSach_Click(object sender, EventArgs e)
        {
            pm.ShowDialog();
        }
    }
}
