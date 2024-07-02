namespace WF_QLTV_Thi
{
	partial class NHANVIEN
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_Xem = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.txb_TenNV = new System.Windows.Forms.TextBox();
			this.txb_MaNV = new System.Windows.Forms.TextBox();
			this.dataGV_NhanVien = new System.Windows.Forms.DataGridView();
			this.txb_sdt = new System.Windows.Forms.TextBox();
			this.txb_taikhoan = new System.Windows.Forms.TextBox();
			this.txb_matkhau = new System.Windows.Forms.TextBox();
			this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
			this.cbb_MaCV = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGV_NhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// dt_NgaySinh
			// 
			this.dt_NgaySinh.CustomFormat = "MM/dd/yyyy";
			this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_NgaySinh.Location = new System.Drawing.Point(46, 252);
			this.dt_NgaySinh.Name = "dt_NgaySinh";
			this.dt_NgaySinh.Size = new System.Drawing.Size(193, 20);
			this.dt_NgaySinh.TabIndex = 37;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(294, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 33);
			this.button1.TabIndex = 36;
			this.button1.Text = "Tạo mới";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_Xem
			// 
			this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xem.Location = new System.Drawing.Point(294, 149);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(67, 33);
			this.btn_Xem.TabIndex = 32;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(294, 344);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(67, 33);
			this.btn_xoa.TabIndex = 35;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(294, 279);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(67, 33);
			this.btn_sua.TabIndex = 34;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(294, 214);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(67, 33);
			this.btn_them.TabIndex = 33;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// txb_TenNV
			// 
			this.txb_TenNV.Location = new System.Drawing.Point(46, 145);
			this.txb_TenNV.Multiline = true;
			this.txb_TenNV.Name = "txb_TenNV";
			this.txb_TenNV.Size = new System.Drawing.Size(193, 30);
			this.txb_TenNV.TabIndex = 30;
			// 
			// txb_MaNV
			// 
			this.txb_MaNV.Location = new System.Drawing.Point(46, 87);
			this.txb_MaNV.Multiline = true;
			this.txb_MaNV.Name = "txb_MaNV";
			this.txb_MaNV.Size = new System.Drawing.Size(193, 30);
			this.txb_MaNV.TabIndex = 29;
			// 
			// dataGV_NhanVien
			// 
			this.dataGV_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGV_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGV_NhanVien.Location = new System.Drawing.Point(385, 57);
			this.dataGV_NhanVien.Name = "dataGV_NhanVien";
			this.dataGV_NhanVien.Size = new System.Drawing.Size(559, 380);
			this.dataGV_NhanVien.TabIndex = 28;
			this.dataGV_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_NhanVien_CellClick);
			// 
			// txb_sdt
			// 
			this.txb_sdt.Location = new System.Drawing.Point(46, 349);
			this.txb_sdt.Multiline = true;
			this.txb_sdt.Name = "txb_sdt";
			this.txb_sdt.Size = new System.Drawing.Size(193, 30);
			this.txb_sdt.TabIndex = 38;
			// 
			// txb_taikhoan
			// 
			this.txb_taikhoan.Location = new System.Drawing.Point(46, 407);
			this.txb_taikhoan.Multiline = true;
			this.txb_taikhoan.Name = "txb_taikhoan";
			this.txb_taikhoan.Size = new System.Drawing.Size(193, 30);
			this.txb_taikhoan.TabIndex = 39;
			// 
			// txb_matkhau
			// 
			this.txb_matkhau.Location = new System.Drawing.Point(46, 465);
			this.txb_matkhau.Multiline = true;
			this.txb_matkhau.Name = "txb_matkhau";
			this.txb_matkhau.Size = new System.Drawing.Size(193, 30);
			this.txb_matkhau.TabIndex = 40;
			// 
			// cbb_gioitinh
			// 
			this.cbb_gioitinh.FormattingEnabled = true;
			this.cbb_gioitinh.Location = new System.Drawing.Point(46, 300);
			this.cbb_gioitinh.Name = "cbb_gioitinh";
			this.cbb_gioitinh.Size = new System.Drawing.Size(193, 21);
			this.cbb_gioitinh.TabIndex = 41;
			// 
			// cbb_MaCV
			// 
			this.cbb_MaCV.FormattingEnabled = true;
			this.cbb_MaCV.Location = new System.Drawing.Point(46, 203);
			this.cbb_MaCV.Name = "cbb_MaCV";
			this.cbb_MaCV.Size = new System.Drawing.Size(193, 21);
			this.cbb_MaCV.TabIndex = 42;
			// 
			// NHANVIEN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 525);
			this.Controls.Add(this.cbb_MaCV);
			this.Controls.Add(this.cbb_gioitinh);
			this.Controls.Add(this.txb_matkhau);
			this.Controls.Add(this.txb_taikhoan);
			this.Controls.Add(this.txb_sdt);
			this.Controls.Add(this.dt_NgaySinh);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Xem);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txb_TenNV);
			this.Controls.Add(this.txb_MaNV);
			this.Controls.Add(this.dataGV_NhanVien);
			this.Name = "NHANVIEN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NHANVIEN";
			this.Load += new System.EventHandler(this.NHANVIEN_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGV_NhanVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dt_NgaySinh;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.TextBox txb_TenNV;
		private System.Windows.Forms.TextBox txb_MaNV;
		private System.Windows.Forms.DataGridView dataGV_NhanVien;
		private System.Windows.Forms.TextBox txb_sdt;
		private System.Windows.Forms.TextBox txb_taikhoan;
		private System.Windows.Forms.TextBox txb_matkhau;
		private System.Windows.Forms.ComboBox cbb_gioitinh;
		private System.Windows.Forms.ComboBox cbb_MaCV;
	}
}