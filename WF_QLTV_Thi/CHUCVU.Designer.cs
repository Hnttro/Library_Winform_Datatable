namespace WF_QLTV_Thi
{
	partial class CHUCVU
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
			this.txb_TenCV = new System.Windows.Forms.TextBox();
			this.txb_MaCV = new System.Windows.Forms.TextBox();
			this.dataGV_CHUCVU = new System.Windows.Forms.DataGridView();
			this.txb_ghichu = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGV_CHUCVU)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(254, 98);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 33);
			this.button1.TabIndex = 42;
			this.button1.Text = "Tạo mới";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_Xem
			// 
			this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xem.Location = new System.Drawing.Point(254, 163);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(67, 33);
			this.btn_Xem.TabIndex = 38;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoa.Location = new System.Drawing.Point(254, 358);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(67, 33);
			this.btn_xoa.TabIndex = 41;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(254, 293);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(67, 33);
			this.btn_sua.TabIndex = 40;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_them.Location = new System.Drawing.Point(254, 228);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(67, 33);
			this.btn_them.TabIndex = 39;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// txb_TenCV
			// 
			this.txb_TenCV.Location = new System.Drawing.Point(29, 192);
			this.txb_TenCV.Multiline = true;
			this.txb_TenCV.Name = "txb_TenCV";
			this.txb_TenCV.Size = new System.Drawing.Size(193, 30);
			this.txb_TenCV.TabIndex = 37;
			// 
			// txb_MaCV
			// 
			this.txb_MaCV.Location = new System.Drawing.Point(29, 130);
			this.txb_MaCV.Multiline = true;
			this.txb_MaCV.Name = "txb_MaCV";
			this.txb_MaCV.Size = new System.Drawing.Size(193, 30);
			this.txb_MaCV.TabIndex = 36;
			// 
			// dataGV_CHUCVU
			// 
			this.dataGV_CHUCVU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGV_CHUCVU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGV_CHUCVU.Location = new System.Drawing.Point(350, 64);
			this.dataGV_CHUCVU.Name = "dataGV_CHUCVU";
			this.dataGV_CHUCVU.Size = new System.Drawing.Size(559, 380);
			this.dataGV_CHUCVU.TabIndex = 35;
			this.dataGV_CHUCVU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CHUCVU_CellClick);
			// 
			// txb_ghichu
			// 
			this.txb_ghichu.Location = new System.Drawing.Point(29, 264);
			this.txb_ghichu.Multiline = true;
			this.txb_ghichu.Name = "txb_ghichu";
			this.txb_ghichu.Size = new System.Drawing.Size(193, 30);
			this.txb_ghichu.TabIndex = 43;
			// 
			// CHUCVU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 555);
			this.Controls.Add(this.txb_ghichu);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Xem);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.txb_TenCV);
			this.Controls.Add(this.txb_MaCV);
			this.Controls.Add(this.dataGV_CHUCVU);
			this.Name = "CHUCVU";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CHUCVU";
			((System.ComponentModel.ISupportInitialize)(this.dataGV_CHUCVU)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.TextBox txb_TenCV;
		private System.Windows.Forms.TextBox txb_MaCV;
		private System.Windows.Forms.DataGridView dataGV_CHUCVU;
		private System.Windows.Forms.TextBox txb_ghichu;
	}
}