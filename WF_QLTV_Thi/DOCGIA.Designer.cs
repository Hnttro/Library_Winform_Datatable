namespace WF_QLTV_Thi
{
	partial class DOCGIA
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
			this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
			this.txb_sdt = new System.Windows.Forms.TextBox();
			this.txb_diachi = new System.Windows.Forms.TextBox();
			this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_Xem = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.txb_TenDG = new System.Windows.Forms.TextBox();
			this.txb_MaDG = new System.Windows.Forms.TextBox();
			this.dataGV_DocGia = new System.Windows.Forms.DataGridView();
			this.cbb_loaiDG = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGV_DocGia)).BeginInit();
			this.SuspendLayout();
			// 
			// cbb_gioitinh
			// 
			this.cbb_gioitinh.FormattingEnabled = true;
			this.cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cbb_gioitinh.Location = new System.Drawing.Point(22, 234);
			this.cbb_gioitinh.Name = "cbb_gioitinh";
			this.cbb_gioitinh.Size = new System.Drawing.Size(193, 21);
			this.cbb_gioitinh.TabIndex = 55;
			// 
			// txb_sdt
			// 
			this.txb_sdt.Location = new System.Drawing.Point(22, 390);
			this.txb_sdt.Multiline = true;
			this.txb_sdt.Name = "txb_sdt";
			this.txb_sdt.Size = new System.Drawing.Size(193, 30);
			this.txb_sdt.TabIndex = 53;
			// 
			// txb_diachi
			// 
			this.txb_diachi.Location = new System.Drawing.Point(22, 332);
			this.txb_diachi.Multiline = true;
			this.txb_diachi.Name = "txb_diachi";
			this.txb_diachi.Size = new System.Drawing.Size(193, 30);
			this.txb_diachi.TabIndex = 52;
			// 
			// dt_NgaySinh
			// 
			this.dt_NgaySinh.CustomFormat = "MM/dd/yyyy";
			this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_NgaySinh.Location = new System.Drawing.Point(22, 186);
			this.dt_NgaySinh.Name = "dt_NgaySinh";
			this.dt_NgaySinh.Size = new System.Drawing.Size(193, 20);
			this.dt_NgaySinh.TabIndex = 51;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(270, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 33);
			this.button1.TabIndex = 50;
			this.button1.Text = "Tạo mới";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_Xem
			// 
			this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xem.Location = new System.Drawing.Point(270, 132);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(67, 33);
			this.btn_Xem.TabIndex = 46;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(270, 327);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(67, 33);
			this.btn_xoa.TabIndex = 49;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(270, 262);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(67, 33);
			this.btn_sua.TabIndex = 48;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(270, 197);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(67, 33);
			this.btn_them.TabIndex = 47;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// txb_TenDG
			// 
			this.txb_TenDG.Location = new System.Drawing.Point(22, 128);
			this.txb_TenDG.Multiline = true;
			this.txb_TenDG.Name = "txb_TenDG";
			this.txb_TenDG.Size = new System.Drawing.Size(193, 30);
			this.txb_TenDG.TabIndex = 45;
			// 
			// txb_MaDG
			// 
			this.txb_MaDG.Location = new System.Drawing.Point(22, 70);
			this.txb_MaDG.Multiline = true;
			this.txb_MaDG.Name = "txb_MaDG";
			this.txb_MaDG.Size = new System.Drawing.Size(193, 30);
			this.txb_MaDG.TabIndex = 44;
			// 
			// dataGV_DocGia
			// 
			this.dataGV_DocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGV_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGV_DocGia.Location = new System.Drawing.Point(361, 40);
			this.dataGV_DocGia.Name = "dataGV_DocGia";
			this.dataGV_DocGia.Size = new System.Drawing.Size(559, 380);
			this.dataGV_DocGia.TabIndex = 43;
			this.dataGV_DocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_DocGia_CellClick);
			// 
			// cbb_loaiDG
			// 
			this.cbb_loaiDG.FormattingEnabled = true;
			this.cbb_loaiDG.Items.AddRange(new object[] {
            "Giáo Viên",
            "Sinh Viên",
            "Nhân Viên"});
			this.cbb_loaiDG.Location = new System.Drawing.Point(22, 283);
			this.cbb_loaiDG.Name = "cbb_loaiDG";
			this.cbb_loaiDG.Size = new System.Drawing.Size(193, 21);
			this.cbb_loaiDG.TabIndex = 56;
			// 
			// DOCGIA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 515);
			this.Controls.Add(this.cbb_loaiDG);
			this.Controls.Add(this.cbb_gioitinh);
			this.Controls.Add(this.txb_sdt);
			this.Controls.Add(this.txb_diachi);
			this.Controls.Add(this.dt_NgaySinh);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Xem);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txb_TenDG);
			this.Controls.Add(this.txb_MaDG);
			this.Controls.Add(this.dataGV_DocGia);
			this.Name = "DOCGIA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DOCGIA";
			this.Load += new System.EventHandler(this.DOCGIA_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGV_DocGia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbb_gioitinh;
		private System.Windows.Forms.TextBox txb_sdt;
		private System.Windows.Forms.TextBox txb_diachi;
		private System.Windows.Forms.DateTimePicker dt_NgaySinh;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.TextBox txb_TenDG;
		private System.Windows.Forms.TextBox txb_MaDG;
		private System.Windows.Forms.DataGridView dataGV_DocGia;
		private System.Windows.Forms.ComboBox cbb_loaiDG;
	}
}