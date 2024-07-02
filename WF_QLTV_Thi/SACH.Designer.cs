namespace WF_QLTV_Thi
{
	partial class SACH
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
			this.button1 = new System.Windows.Forms.Button();
			this.btn_Xem = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.dataGV_Sach = new System.Windows.Forms.DataGridView();
			this.txb_MaS = new System.Windows.Forms.TextBox();
			this.txb_TenS = new System.Windows.Forms.TextBox();
			this.txb_nhaXB = new System.Windows.Forms.TextBox();
			this.txb_namXB = new System.Windows.Forms.TextBox();
			this.txb_dongia = new System.Windows.Forms.TextBox();
			this.txb_tinhtrang = new System.Windows.Forms.TextBox();
			this.cbb_TheLoai = new System.Windows.Forms.ComboBox();
			this.cbb_TacGia = new System.Windows.Forms.ComboBox();
			this.nd_sl = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGV_Sach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nd_sl)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(297, 129);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 33);
			this.button1.TabIndex = 32;
			this.button1.Text = "Tạo mới";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_Xem
			// 
			this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xem.Location = new System.Drawing.Point(297, 194);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(67, 33);
			this.btn_Xem.TabIndex = 28;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(297, 389);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(67, 33);
			this.btn_xoa.TabIndex = 31;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(297, 324);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(67, 33);
			this.btn_sua.TabIndex = 30;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(297, 259);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(67, 33);
			this.btn_them.TabIndex = 29;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// dataGV_Sach
			// 
			this.dataGV_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGV_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGV_Sach.Location = new System.Drawing.Point(370, 91);
			this.dataGV_Sach.Name = "dataGV_Sach";
			this.dataGV_Sach.Size = new System.Drawing.Size(559, 380);
			this.dataGV_Sach.TabIndex = 27;
			this.dataGV_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Sach_CellClick);
			// 
			// txb_MaS
			// 
			this.txb_MaS.Location = new System.Drawing.Point(51, 91);
			this.txb_MaS.Multiline = true;
			this.txb_MaS.Name = "txb_MaS";
			this.txb_MaS.Size = new System.Drawing.Size(193, 28);
			this.txb_MaS.TabIndex = 33;
			// 
			// txb_TenS
			// 
			this.txb_TenS.Location = new System.Drawing.Point(51, 140);
			this.txb_TenS.Multiline = true;
			this.txb_TenS.Name = "txb_TenS";
			this.txb_TenS.Size = new System.Drawing.Size(193, 28);
			this.txb_TenS.TabIndex = 34;
			// 
			// txb_nhaXB
			// 
			this.txb_nhaXB.Location = new System.Drawing.Point(51, 273);
			this.txb_nhaXB.Multiline = true;
			this.txb_nhaXB.Name = "txb_nhaXB";
			this.txb_nhaXB.Size = new System.Drawing.Size(193, 28);
			this.txb_nhaXB.TabIndex = 35;
			// 
			// txb_namXB
			// 
			this.txb_namXB.Location = new System.Drawing.Point(51, 322);
			this.txb_namXB.Multiline = true;
			this.txb_namXB.Name = "txb_namXB";
			this.txb_namXB.Size = new System.Drawing.Size(193, 28);
			this.txb_namXB.TabIndex = 36;
			// 
			// txb_dongia
			// 
			this.txb_dongia.Location = new System.Drawing.Point(51, 412);
			this.txb_dongia.Multiline = true;
			this.txb_dongia.Name = "txb_dongia";
			this.txb_dongia.Size = new System.Drawing.Size(193, 28);
			this.txb_dongia.TabIndex = 37;
			// 
			// txb_tinhtrang
			// 
			this.txb_tinhtrang.Location = new System.Drawing.Point(51, 461);
			this.txb_tinhtrang.Multiline = true;
			this.txb_tinhtrang.Name = "txb_tinhtrang";
			this.txb_tinhtrang.Size = new System.Drawing.Size(193, 28);
			this.txb_tinhtrang.TabIndex = 38;
			// 
			// cbb_TheLoai
			// 
			this.cbb_TheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbb_TheLoai.FormattingEnabled = true;
			this.cbb_TheLoai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbb_TheLoai.Location = new System.Drawing.Point(51, 189);
			this.cbb_TheLoai.Name = "cbb_TheLoai";
			this.cbb_TheLoai.Size = new System.Drawing.Size(193, 21);
			this.cbb_TheLoai.TabIndex = 39;
			// 
			// cbb_TacGia
			// 
			this.cbb_TacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbb_TacGia.FormattingEnabled = true;
			this.cbb_TacGia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbb_TacGia.Location = new System.Drawing.Point(51, 231);
			this.cbb_TacGia.Name = "cbb_TacGia";
			this.cbb_TacGia.Size = new System.Drawing.Size(193, 21);
			this.cbb_TacGia.TabIndex = 40;
			// 
			// nd_sl
			// 
			this.nd_sl.Location = new System.Drawing.Point(51, 371);
			this.nd_sl.Name = "nd_sl";
			this.nd_sl.Size = new System.Drawing.Size(193, 20);
			this.nd_sl.TabIndex = 41;
			// 
			// SACH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 569);
			this.Controls.Add(this.nd_sl);
			this.Controls.Add(this.cbb_TacGia);
			this.Controls.Add(this.cbb_TheLoai);
			this.Controls.Add(this.txb_tinhtrang);
			this.Controls.Add(this.txb_dongia);
			this.Controls.Add(this.txb_namXB);
			this.Controls.Add(this.txb_nhaXB);
			this.Controls.Add(this.txb_TenS);
			this.Controls.Add(this.txb_MaS);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Xem);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.dataGV_Sach);
			this.Name = "SACH";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SACH";
			this.Load += new System.EventHandler(this.SACH_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGV_Sach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nd_sl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.DataGridView dataGV_Sach;
		private System.Windows.Forms.TextBox txb_MaS;
		private System.Windows.Forms.TextBox txb_TenS;
		private System.Windows.Forms.TextBox txb_nhaXB;
		private System.Windows.Forms.TextBox txb_namXB;
		private System.Windows.Forms.TextBox txb_dongia;
		private System.Windows.Forms.TextBox txb_tinhtrang;
		private System.Windows.Forms.ComboBox cbb_TheLoai;
		private System.Windows.Forms.ComboBox cbb_TacGia;
		private System.Windows.Forms.NumericUpDown nd_sl;
	}
}