namespace QLKhachSan
{
    partial class FormPhong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnXoaP = new System.Windows.Forms.Button();
            this.btnSuaP = new System.Windows.Forms.Button();
            this.btnThemP = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.btnSuaLP = new System.Windows.Forms.Button();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbLoaiPhong);
            this.tabPage1.Controls.Add(this.txtMaPhong);
            this.tabPage1.Controls.Add(this.btnXoaP);
            this.tabPage1.Controls.Add(this.btnSuaP);
            this.tabPage1.Controls.Add(this.btnThemP);
            this.tabPage1.Controls.Add(this.dgvPhong);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(142, 157);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(174, 28);
            this.cbLoaiPhong.TabIndex = 8;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(142, 98);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(174, 27);
            this.txtMaPhong.TabIndex = 7;
            // 
            // btnXoaP
            // 
            this.btnXoaP.Location = new System.Drawing.Point(236, 259);
            this.btnXoaP.Name = "btnXoaP";
            this.btnXoaP.Size = new System.Drawing.Size(80, 33);
            this.btnXoaP.TabIndex = 6;
            this.btnXoaP.Text = "Xóa";
            this.btnXoaP.UseVisualStyleBackColor = true;
            // 
            // btnSuaP
            // 
            this.btnSuaP.Location = new System.Drawing.Point(133, 259);
            this.btnSuaP.Name = "btnSuaP";
            this.btnSuaP.Size = new System.Drawing.Size(80, 33);
            this.btnSuaP.TabIndex = 5;
            this.btnSuaP.Text = "Sửa";
            this.btnSuaP.UseVisualStyleBackColor = true;
            // 
            // btnThemP
            // 
            this.btnThemP.Location = new System.Drawing.Point(31, 259);
            this.btnThemP.Name = "btnThemP";
            this.btnThemP.Size = new System.Drawing.Size(80, 33);
            this.btnThemP.TabIndex = 4;
            this.btnThemP.Text = "Thêm";
            this.btnThemP.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(349, 98);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(273, 237);
            this.dgvPhong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(221, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGia);
            this.tabPage2.Controls.Add(this.txtSoNguoi);
            this.tabPage2.Controls.Add(this.txtMaLoai);
            this.tabPage2.Controls.Add(this.btnXoaLP);
            this.tabPage2.Controls.Add(this.btnSuaLP);
            this.tabPage2.Controls.Add(this.btnThemLP);
            this.tabPage2.Controls.Add(this.dgvLoaiPhong);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Loại Phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(130, 200);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(208, 27);
            this.txtGia.TabIndex = 10;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(130, 149);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(208, 27);
            this.txtSoNguoi.TabIndex = 9;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(130, 96);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(208, 27);
            this.txtMaLoai.TabIndex = 8;
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.Location = new System.Drawing.Point(256, 270);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(82, 33);
            this.btnXoaLP.TabIndex = 7;
            this.btnXoaLP.Text = "Xóa";
            this.btnXoaLP.UseVisualStyleBackColor = true;
            // 
            // btnSuaLP
            // 
            this.btnSuaLP.Location = new System.Drawing.Point(151, 270);
            this.btnSuaLP.Name = "btnSuaLP";
            this.btnSuaLP.Size = new System.Drawing.Size(82, 33);
            this.btnSuaLP.TabIndex = 6;
            this.btnSuaLP.Text = "Sửa";
            this.btnSuaLP.UseVisualStyleBackColor = true;
            // 
            // btnThemLP
            // 
            this.btnThemLP.Location = new System.Drawing.Point(40, 270);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(84, 33);
            this.btnThemLP.TabIndex = 5;
            this.btnThemLP.Text = "Thêm";
            this.btnThemLP.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(364, 96);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersWidth = 51;
            this.dgvLoaiPhong.RowTemplate.Height = 24;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(270, 244);
            this.dgvLoaiPhong.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Người";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(261, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại Phòng";
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phòng";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnXoaP;
        private System.Windows.Forms.Button btnSuaP;
        private System.Windows.Forms.Button btnThemP;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.Button btnSuaLP;
        private System.Windows.Forms.Button btnThemLP;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}