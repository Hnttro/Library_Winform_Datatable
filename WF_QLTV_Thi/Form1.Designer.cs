namespace WF_QLTV_Thi
{
	partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new WF_QLTV_Thi.QLThuVienDataSet();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.BookContaner = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_TheLoai = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_QuanLySach = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_TacGia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sach = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DocGia = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.BookTime = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_MuonTraSach = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.TenNVHienThi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            this.BookContaner.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.qLThuVienDataSet;
            this.bindingSource1.Position = 0;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 8;
            this.SidebarTimer.Tick += new System.EventHandler(this.sidebarTick);
            // 
            // BookContaner
            // 
            this.BookContaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BookContaner.Controls.Add(this.panel11);
            this.BookContaner.Controls.Add(this.panel4);
            this.BookContaner.Controls.Add(this.panel8);
            this.BookContaner.Controls.Add(this.panel1);
            this.BookContaner.Location = new System.Drawing.Point(0, 162);
            this.BookContaner.Margin = new System.Windows.Forms.Padding(0);
            this.BookContaner.MaximumSize = new System.Drawing.Size(180, 189);
            this.BookContaner.MinimumSize = new System.Drawing.Size(180, 57);
            this.BookContaner.Name = "BookContaner";
            this.BookContaner.Size = new System.Drawing.Size(180, 57);
            this.BookContaner.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_TheLoai);
            this.panel11.Location = new System.Drawing.Point(0, 144);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(175, 43);
            this.panel11.TabIndex = 5;
            // 
            // btn_TheLoai
            // 
            this.btn_TheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btn_TheLoai.FlatAppearance.BorderSize = 0;
            this.btn_TheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_TheLoai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TheLoai.Image = global::WF_QLTV_Thi.Properties.Resources.tròn;
            this.btn_TheLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TheLoai.Location = new System.Drawing.Point(-12, -5);
            this.btn_TheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TheLoai.Name = "btn_TheLoai";
            this.btn_TheLoai.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_TheLoai.Size = new System.Drawing.Size(197, 54);
            this.btn_TheLoai.TabIndex = 1;
            this.btn_TheLoai.Text = "     Thể Loại";
            this.btn_TheLoai.UseVisualStyleBackColor = false;
            this.btn_TheLoai.Click += new System.EventHandler(this.btn_TheLoai_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_QuanLySach);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 52);
            this.panel4.TabIndex = 4;
            // 
            // btn_QuanLySach
            // 
            this.btn_QuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_QuanLySach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_QuanLySach.FlatAppearance.BorderSize = 0;
            this.btn_QuanLySach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_QuanLySach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_QuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLySach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLySach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QuanLySach.Image = global::WF_QLTV_Thi.Properties.Resources.diary_bookmarks;
            this.btn_QuanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLySach.Location = new System.Drawing.Point(-12, -1);
            this.btn_QuanLySach.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QuanLySach.Name = "btn_QuanLySach";
            this.btn_QuanLySach.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_QuanLySach.Size = new System.Drawing.Size(197, 54);
            this.btn_QuanLySach.TabIndex = 1;
            this.btn_QuanLySach.Text = "        Quản Lý Sách";
            this.btn_QuanLySach.UseVisualStyleBackColor = false;
            this.btn_QuanLySach.Click += new System.EventHandler(this.btn_QuanLySach_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_TacGia);
            this.panel8.Location = new System.Drawing.Point(0, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 43);
            this.panel8.TabIndex = 4;
            // 
            // btn_TacGia
            // 
            this.btn_TacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btn_TacGia.FlatAppearance.BorderSize = 0;
            this.btn_TacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_TacGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TacGia.Image = global::WF_QLTV_Thi.Properties.Resources.tròn;
            this.btn_TacGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TacGia.Location = new System.Drawing.Point(-12, -5);
            this.btn_TacGia.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TacGia.Name = "btn_TacGia";
            this.btn_TacGia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_TacGia.Size = new System.Drawing.Size(197, 54);
            this.btn_TacGia.TabIndex = 1;
            this.btn_TacGia.Text = "   Tác Giả";
            this.btn_TacGia.UseVisualStyleBackColor = false;
            this.btn_TacGia.Click += new System.EventHandler(this.btn_TacGia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sach);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 43);
            this.panel1.TabIndex = 4;
            // 
            // btn_Sach
            // 
            this.btn_Sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btn_Sach.FlatAppearance.BorderSize = 0;
            this.btn_Sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sach.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sach.Image = global::WF_QLTV_Thi.Properties.Resources.tròn;
            this.btn_Sach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sach.Location = new System.Drawing.Point(-12, -5);
            this.btn_Sach.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sach.Name = "btn_Sach";
            this.btn_Sach.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Sach.Size = new System.Drawing.Size(197, 54);
            this.btn_Sach.TabIndex = 1;
            this.btn_Sach.Text = "Sách";
            this.btn_Sach.UseVisualStyleBackColor = false;
            this.btn_Sach.Click += new System.EventHandler(this.btn_Sach_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(911, 177);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 52);
            this.panel6.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::WF_QLTV_Thi.Properties.Resources.diary_bookmarks;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-12, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(197, 54);
            this.button6.TabIndex = 1;
            this.button6.Text = "             button2";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_DocGia);
            this.panel3.Location = new System.Drawing.Point(3, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 52);
            this.panel3.TabIndex = 4;
            // 
            // btn_DocGia
            // 
            this.btn_DocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_DocGia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DocGia.FlatAppearance.BorderSize = 0;
            this.btn_DocGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_DocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_DocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DocGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DocGia.Image = global::WF_QLTV_Thi.Properties.Resources.doc;
            this.btn_DocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DocGia.Location = new System.Drawing.Point(-12, 0);
            this.btn_DocGia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DocGia.Name = "btn_DocGia";
            this.btn_DocGia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_DocGia.Size = new System.Drawing.Size(197, 54);
            this.btn_DocGia.TabIndex = 1;
            this.btn_DocGia.Text = "        Độc Giả";
            this.btn_DocGia.UseVisualStyleBackColor = false;
            this.btn_DocGia.Click += new System.EventHandler(this.btn_DocGia_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button9);
            this.panel9.Location = new System.Drawing.Point(911, 394);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 43);
            this.panel9.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = global::WF_QLTV_Thi.Properties.Resources.tròn;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-12, -5);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(197, 54);
            this.button9.TabIndex = 1;
            this.button9.Text = "Sách";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button10);
            this.panel10.Location = new System.Drawing.Point(911, 290);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(175, 43);
            this.panel10.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Image = global::WF_QLTV_Thi.Properties.Resources.tròn;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-12, -5);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(197, 54);
            this.button10.TabIndex = 1;
            this.button10.Text = "Sách";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // BookTime
            // 
            this.BookTime.Interval = 10;
            this.BookTime.Tick += new System.EventHandler(this.BookTime_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.BookContaner);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Controls.Add(this.panel14);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(180, 703);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 703);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(63, 703);
            this.sidebar.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 156);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WF_QLTV_Thi.Properties.Resources.lbb;
            this.pictureBox1.Location = new System.Drawing.Point(57, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WF_QLTV_Thi.Properties.Resources.iconmenu;
            this.button1.Location = new System.Drawing.Point(8, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 46);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_NhanVien);
            this.panel7.Location = new System.Drawing.Point(3, 280);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 52);
            this.panel7.TabIndex = 5;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_NhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_NhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NhanVien.Image = global::WF_QLTV_Thi.Properties.Resources.nv;
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(-12, 0);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_NhanVien.Size = new System.Drawing.Size(197, 54);
            this.btn_NhanVien.TabIndex = 1;
            this.btn_NhanVien.Text = "        Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_MuonTraSach);
            this.panel5.Location = new System.Drawing.Point(3, 338);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 52);
            this.panel5.TabIndex = 6;
            // 
            // btn_MuonTraSach
            // 
            this.btn_MuonTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_MuonTraSach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_MuonTraSach.FlatAppearance.BorderSize = 0;
            this.btn_MuonTraSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_MuonTraSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_MuonTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MuonTraSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_MuonTraSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MuonTraSach.Image = global::WF_QLTV_Thi.Properties.Resources.ms;
            this.btn_MuonTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MuonTraSach.Location = new System.Drawing.Point(-12, 0);
            this.btn_MuonTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MuonTraSach.Name = "btn_MuonTraSach";
            this.btn_MuonTraSach.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_MuonTraSach.Size = new System.Drawing.Size(197, 54);
            this.btn_MuonTraSach.TabIndex = 1;
            this.btn_MuonTraSach.Text = "          Mượn Trả Sách";
            this.btn_MuonTraSach.UseVisualStyleBackColor = false;
            this.btn_MuonTraSach.Click += new System.EventHandler(this.btn_MuonTraSach_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_thongke);
            this.panel12.Location = new System.Drawing.Point(3, 396);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(180, 52);
            this.panel12.TabIndex = 5;
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_thongke.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_thongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_thongke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thongke.Image = global::WF_QLTV_Thi.Properties.Resources.tt;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(-12, 0);
            this.btn_thongke.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btn_thongke.Size = new System.Drawing.Size(197, 54);
            this.btn_thongke.TabIndex = 1;
            this.btn_thongke.Text = "        Thống Kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btn_DangXuat);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(3, 454);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(180, 52);
            this.panel14.TabIndex = 6;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_DangXuat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_DangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangXuat.Image = global::WF_QLTV_Thi.Properties.Resources.log;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(-12, 0);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btn_DangXuat.Size = new System.Drawing.Size(197, 54);
            this.btn_DangXuat.TabIndex = 1;
            this.btn_DangXuat.Text = "        Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            // 
            // TenNVHienThi
            // 
            this.TenNVHienThi.AutoSize = true;
            this.TenNVHienThi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNVHienThi.Location = new System.Drawing.Point(1035, 9);
            this.TenNVHienThi.Name = "TenNVHienThi";
            this.TenNVHienThi.Size = new System.Drawing.Size(51, 21);
            this.TenNVHienThi.TabIndex = 0;
            this.TenNVHienThi.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::WF_QLTV_Thi.Properties.Resources.lll;
            this.ClientSize = new System.Drawing.Size(1152, 703);
            this.Controls.Add(this.TenNVHienThi);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            this.BookContaner.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Panel BookContaner;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_QuanLySach;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_DocGia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer BookTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Sach;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_TacGia;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_TheLoai;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_MuonTraSach;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Label TenNVHienThi;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}

