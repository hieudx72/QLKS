﻿namespace QLKhachSan
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDatPhong1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThietBiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSPDT = new System.Windows.Forms.Label();
            this.lblSPDD = new System.Windows.Forms.Label();
            this.lblSPT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnKhachHang,
            this.mnDatPhong1,
            this.mnQuanLy,
            this.mnTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDoiMatKhau,
            this.mnDangXuat,
            this.toolStripSeparator1,
            this.mnThoat});
            this.mnHeThong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(102, 27);
            this.mnHeThong.Text = "Hệ Thống";
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.Size = new System.Drawing.Size(204, 28);
            this.mnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.mnDoiMatKhau.Click += new System.EventHandler(this.mnDoiMatKhau_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(204, 28);
            this.mnDangXuat.Text = "Đăng Xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(204, 28);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // mnKhachHang
            // 
            this.mnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnKhachHang.Name = "mnKhachHang";
            this.mnKhachHang.Size = new System.Drawing.Size(120, 27);
            this.mnKhachHang.Text = "Khách Hàng";
            this.mnKhachHang.Click += new System.EventHandler(this.mnKhachHang_Click);
            // 
            // mnDatPhong1
            // 
            this.mnDatPhong1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDatPhong,
            this.mnThuePhong});
            this.mnDatPhong1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnDatPhong1.Name = "mnDatPhong1";
            this.mnDatPhong1.Size = new System.Drawing.Size(109, 27);
            this.mnDatPhong1.Text = "Đặt Phòng";
            // 
            // mnDatPhong
            // 
            this.mnDatPhong.Name = "mnDatPhong";
            this.mnDatPhong.Size = new System.Drawing.Size(189, 28);
            this.mnDatPhong.Text = "Đặt Phòng";
            this.mnDatPhong.Click += new System.EventHandler(this.mnDatPhong_Click);
            // 
            // mnThuePhong
            // 
            this.mnThuePhong.Name = "mnThuePhong";
            this.mnThuePhong.Size = new System.Drawing.Size(189, 28);
            this.mnThuePhong.Text = "Thuê Phòng";
            this.mnThuePhong.Click += new System.EventHandler(this.mnThuePhong_Click);
            // 
            // mnQuanLy
            // 
            this.mnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPhong,
            this.mnThietBiPhong,
            this.mnDichVu,
            this.mnNhanVien});
            this.mnQuanLy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnQuanLy.Name = "mnQuanLy";
            this.mnQuanLy.Size = new System.Drawing.Size(89, 27);
            this.mnQuanLy.Text = "Quản Lý";
            // 
            // mnPhong
            // 
            this.mnPhong.Name = "mnPhong";
            this.mnPhong.Size = new System.Drawing.Size(212, 28);
            this.mnPhong.Text = "Phòng";
            this.mnPhong.Click += new System.EventHandler(this.mnPhong_Click);
            // 
            // mnThietBiPhong
            // 
            this.mnThietBiPhong.Name = "mnThietBiPhong";
            this.mnThietBiPhong.Size = new System.Drawing.Size(212, 28);
            this.mnThietBiPhong.Text = "Thiết Bị Phòng";
            this.mnThietBiPhong.Click += new System.EventHandler(this.mnThietBiPhong_Click);
            // 
            // mnDichVu
            // 
            this.mnDichVu.Name = "mnDichVu";
            this.mnDichVu.Size = new System.Drawing.Size(212, 28);
            this.mnDichVu.Text = "Dịch Vụ";
            this.mnDichVu.Click += new System.EventHandler(this.mnDichVu_Click);
            // 
            // mnNhanVien
            // 
            this.mnNhanVien.Name = "mnNhanVien";
            this.mnNhanVien.Size = new System.Drawing.Size(212, 28);
            this.mnNhanVien.Text = "Nhân Viên";
            this.mnNhanVien.Click += new System.EventHandler(this.mnNhanVien_Click);
            // 
            // mnTroGiup
            // 
            this.mnTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongTin});
            this.mnTroGiup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnTroGiup.Name = "mnTroGiup";
            this.mnTroGiup.Size = new System.Drawing.Size(94, 27);
            this.mnTroGiup.Text = "Trợ Giúp";
            // 
            // mnThongTin
            // 
            this.mnThongTin.Name = "mnThongTin";
            this.mnThongTin.Size = new System.Drawing.Size(175, 28);
            this.mnThongTin.Text = "Thông Tin";
            this.mnThongTin.Click += new System.EventHandler(this.mnThongTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(536, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hi";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.ForeColor = System.Drawing.Color.Blue;
            this.lblTenDN.Location = new System.Drawing.Point(46, 46);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(31, 24);
            this.lblTenDN.TabIndex = 3;
            this.lblTenDN.Text = "ad";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(41, 79);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblSPDT);
            this.groupBox1.Controls.Add(this.lblSPDD);
            this.groupBox1.Controls.Add(this.lblSPT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblSPDT
            // 
            this.lblSPDT.AutoSize = true;
            this.lblSPDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPDT.Location = new System.Drawing.Point(225, 155);
            this.lblSPDT.Name = "lblSPDT";
            this.lblSPDT.Size = new System.Drawing.Size(60, 24);
            this.lblSPDT.TabIndex = 5;
            this.lblSPDT.Text = "label8";
            // 
            // lblSPDD
            // 
            this.lblSPDD.AutoSize = true;
            this.lblSPDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPDD.Location = new System.Drawing.Point(225, 102);
            this.lblSPDD.Name = "lblSPDD";
            this.lblSPDD.Size = new System.Drawing.Size(60, 24);
            this.lblSPDD.TabIndex = 4;
            this.lblSPDD.Text = "label7";
            // 
            // lblSPT
            // 
            this.lblSPT.AutoSize = true;
            this.lblSPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPT.Location = new System.Drawing.Point(225, 52);
            this.lblSPT.Name = "lblSPT";
            this.lblSPT.Size = new System.Drawing.Size(60, 24);
            this.lblSPT.TabIndex = 3;
            this.lblSPT.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số phòng đã thuê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số phòng đã đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số phòng trống:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.lvPhong);
            this.groupBox2.Location = new System.Drawing.Point(375, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 404);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // lvPhong
            // 
            this.lvPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPhong.HideSelection = false;
            this.lvPhong.LargeImageList = this.imageList;
            this.lvPhong.Location = new System.Drawing.Point(20, 33);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(650, 351);
            this.lvPhong.TabIndex = 0;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "home.png");
            this.imageList.Images.SetKeyName(1, "home1.png");
            this.imageList.Images.SetKeyName(2, "home2.png");
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(583, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1079, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Khách Sạn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnDatPhong1;
        private System.Windows.Forms.ToolStripMenuItem mnDatPhong;
        private System.Windows.Forms.ToolStripMenuItem mnThuePhong;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnPhong;
        private System.Windows.Forms.ToolStripMenuItem mnThietBiPhong;
        private System.Windows.Forms.ToolStripMenuItem mnDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSPDT;
        private System.Windows.Forms.Label lblSPDD;
        private System.Windows.Forms.Label lblSPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}