namespace WF_QLTV_Thi
{
	partial class TACGIA
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
			this.dataGV_TacGia = new System.Windows.Forms.DataGridView();
			this.txb_MaTG = new System.Windows.Forms.TextBox();
			this.txb_TenTG = new System.Windows.Forms.TextBox();
			this.txb_quocgia = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_Xem = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGV_TacGia)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGV_TacGia
			// 
			this.dataGV_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGV_TacGia.Location = new System.Drawing.Point(367, 77);
			this.dataGV_TacGia.Name = "dataGV_TacGia";
			this.dataGV_TacGia.Size = new System.Drawing.Size(559, 380);
			this.dataGV_TacGia.TabIndex = 0;
			this.dataGV_TacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_TacGia_CellClick);
			// 
			// txb_MaTG
			// 
			this.txb_MaTG.Location = new System.Drawing.Point(46, 143);
			this.txb_MaTG.Multiline = true;
			this.txb_MaTG.Name = "txb_MaTG";
			this.txb_MaTG.Size = new System.Drawing.Size(193, 30);
			this.txb_MaTG.TabIndex = 1;
			// 
			// txb_TenTG
			// 
			this.txb_TenTG.Location = new System.Drawing.Point(46, 205);
			this.txb_TenTG.Multiline = true;
			this.txb_TenTG.Name = "txb_TenTG";
			this.txb_TenTG.Size = new System.Drawing.Size(193, 30);
			this.txb_TenTG.TabIndex = 2;
			// 
			// txb_quocgia
			// 
			this.txb_quocgia.Location = new System.Drawing.Point(46, 335);
			this.txb_quocgia.Multiline = true;
			this.txb_quocgia.Name = "txb_quocgia";
			this.txb_quocgia.Size = new System.Drawing.Size(193, 30);
			this.txb_quocgia.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(294, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 33);
			this.button1.TabIndex = 26;
			this.button1.Text = "Tạo mới";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_Xem
			// 
			this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xem.Location = new System.Drawing.Point(294, 180);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(67, 33);
			this.btn_Xem.TabIndex = 22;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(294, 375);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(67, 33);
			this.btn_xoa.TabIndex = 25;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(294, 310);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(67, 33);
			this.btn_sua.TabIndex = 24;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(294, 245);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(67, 33);
			this.btn_them.TabIndex = 23;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// dt_NgaySinh
			// 
			this.dt_NgaySinh.CustomFormat = "MM/dd/yyyy";
			this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_NgaySinh.Location = new System.Drawing.Point(46, 279);
			this.dt_NgaySinh.Name = "dt_NgaySinh";
			this.dt_NgaySinh.Size = new System.Drawing.Size(193, 20);
			this.dt_NgaySinh.TabIndex = 27;
			// 
			// TACGIA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 542);
			this.Controls.Add(this.dt_NgaySinh);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Xem);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txb_quocgia);
			this.Controls.Add(this.txb_TenTG);
			this.Controls.Add(this.txb_MaTG);
			this.Controls.Add(this.dataGV_TacGia);
			this.Name = "TACGIA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TACGIA";
			((System.ComponentModel.ISupportInitialize)(this.dataGV_TacGia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGV_TacGia;
		private System.Windows.Forms.TextBox txb_MaTG;
		private System.Windows.Forms.TextBox txb_TenTG;
		private System.Windows.Forms.TextBox txb_quocgia;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.DateTimePicker dt_NgaySinh;
	}
}