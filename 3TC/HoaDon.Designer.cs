﻿namespace _3TC
{
    partial class HoaDon
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
            Box1 = new GroupBox();
            txt_MaHoadon = new TextBox();
            txt_BienSoXe = new TextBox();
            txt_TenKhachHang = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cb_HangXe = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            listHoaDon = new ListView();
            cMaHoaDon = new ColumnHeader();
            cKhachHang = new ColumnHeader();
            cBienSoXe = new ColumnHeader();
            cHangXe = new ColumnHeader();
            cTongNgayThue = new ColumnHeader();
            cDonGia = new ColumnHeader();
            cThanhTien = new ColumnHeader();
            lbl_ThanhTien = new Label();
            lbl_DonGia = new Label();
            label13 = new Label();
            label11 = new Label();
            lbl_TongNgayThueXe = new Label();
            label8 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btn_CapNhap = new Button();
            Box1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Box1
            // 
            Box1.Controls.Add(txt_MaHoadon);
            Box1.Controls.Add(txt_BienSoXe);
            Box1.Controls.Add(txt_TenKhachHang);
            Box1.Controls.Add(label7);
            Box1.Controls.Add(label6);
            Box1.Controls.Add(label5);
            Box1.Controls.Add(cb_HangXe);
            Box1.Controls.Add(comboBox1);
            Box1.Controls.Add(dateTimePicker2);
            Box1.Controls.Add(dateTimePicker1);
            Box1.Controls.Add(label4);
            Box1.Controls.Add(label9);
            Box1.Controls.Add(label3);
            Box1.Controls.Add(label2);
            Box1.Location = new Point(9, 35);
            Box1.Margin = new Padding(2);
            Box1.Name = "Box1";
            Box1.Padding = new Padding(2);
            Box1.Size = new Size(1117, 250);
            Box1.TabIndex = 0;
            Box1.TabStop = false;
            Box1.Text = "Thông Tin";
            // 
            // txt_MaHoadon
            // 
            txt_MaHoadon.Location = new Point(188, 55);
            txt_MaHoadon.Name = "txt_MaHoadon";
            txt_MaHoadon.Size = new Size(216, 22);
            txt_MaHoadon.TabIndex = 4;
            // 
            // txt_BienSoXe
            // 
            txt_BienSoXe.Location = new Point(769, 115);
            txt_BienSoXe.Name = "txt_BienSoXe";
            txt_BienSoXe.Size = new Size(125, 22);
            txt_BienSoXe.TabIndex = 4;
            // 
            // txt_TenKhachHang
            // 
            txt_TenKhachHang.Location = new Point(769, 51);
            txt_TenKhachHang.Name = "txt_TenKhachHang";
            txt_TenKhachHang.Size = new Size(125, 22);
            txt_TenKhachHang.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(599, 180);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 3;
            label7.Text = "Hãng Xe :";
            label7.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 192, 0);
            label6.Location = new Point(599, 115);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 3;
            label6.Text = "Biển Số Xe :";
            label6.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(599, 50);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 3;
            label5.Text = "Tên Khách Hàng :";
            label5.Click += label5_Click;
            // 
            // cb_HangXe
            // 
            cb_HangXe.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_HangXe.FormattingEnabled = true;
            cb_HangXe.Items.AddRange(new object[] { "VinFast", "Volkswagen", "Toyota", "Mercedes-Benz", "BMW", "Honda", "Hyundai", "Stellantis", "Ford", "SAIC", "General Motors", "Suzuki", "Fiat" });
            cb_HangXe.Location = new Point(769, 172);
            cb_HangXe.Margin = new Padding(2);
            cb_HangXe.Name = "cb_HangXe";
            cb_HangXe.Size = new Size(133, 27);
            cb_HangXe.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mai Văn Trọng", "Phạm Huy Long", "Trần Vĩ" });
            comboBox1.Location = new Point(188, 192);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 27);
            comboBox1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(188, 147);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(234, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(188, 109);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(44, 198);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 0;
            label4.Text = "Tên Nhân Viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 192);
            label9.Location = new Point(44, 155);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 19);
            label9.TabIndex = 0;
            label9.Text = "Ngày Trả Xe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(44, 111);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 0;
            label3.Text = "Ngày Thuê Xe :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(44, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 0;
            label2.Text = "Mã Hóa Đơn:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(460, -1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 33);
            label1.TabIndex = 1;
            label1.Text = "Hóa Đơn Thuê xe";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 688);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 43);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listHoaDon);
            groupBox1.Controls.Add(lbl_ThanhTien);
            groupBox1.Controls.Add(lbl_DonGia);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lbl_TongNgayThueXe);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 293);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1118, 292);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // listHoaDon
            // 
            listHoaDon.Columns.AddRange(new ColumnHeader[] { cMaHoaDon, cKhachHang, cBienSoXe, cHangXe, cTongNgayThue, cDonGia, cThanhTien });
            listHoaDon.Location = new Point(189, 67);
            listHoaDon.Name = "listHoaDon";
            listHoaDon.Size = new Size(929, 219);
            listHoaDon.TabIndex = 4;
            listHoaDon.UseCompatibleStateImageBehavior = false;
            listHoaDon.View = View.Details;
            listHoaDon.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cMaHoaDon
            // 
            cMaHoaDon.Text = "Mã Hóa Đơn";
            cMaHoaDon.Width = 100;
            // 
            // cKhachHang
            // 
            cKhachHang.Text = "Tên Khách Hàng";
            cKhachHang.Width = 110;
            // 
            // cBienSoXe
            // 
            cBienSoXe.Text = "Biển Số Xe";
            cBienSoXe.TextAlign = HorizontalAlignment.Center;
            cBienSoXe.Width = 90;
            // 
            // cHangXe
            // 
            cHangXe.Text = "Hãng Xe";
            cHangXe.TextAlign = HorizontalAlignment.Center;
            cHangXe.Width = 80;
            // 
            // cTongNgayThue
            // 
            cTongNgayThue.Text = "Tổng Ngày Thuê";
            cTongNgayThue.TextAlign = HorizontalAlignment.Center;
            cTongNgayThue.Width = 120;
            // 
            // cDonGia
            // 
            cDonGia.Text = "Đơn Giá";
            cDonGia.TextAlign = HorizontalAlignment.Center;
            cDonGia.Width = 80;
            // 
            // cThanhTien
            // 
            cThanhTien.Text = "Thành Tiền";
            cThanhTien.TextAlign = HorizontalAlignment.Center;
            cThanhTien.Width = 100;
            // 
            // lbl_ThanhTien
            // 
            lbl_ThanhTien.BorderStyle = BorderStyle.Fixed3D;
            lbl_ThanhTien.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            lbl_ThanhTien.Location = new Point(907, 23);
            lbl_ThanhTien.Name = "lbl_ThanhTien";
            lbl_ThanhTien.Size = new Size(133, 31);
            lbl_ThanhTien.TabIndex = 3;
            lbl_ThanhTien.Click += lbl_ThanhTien_Click;
            // 
            // lbl_DonGia
            // 
            lbl_DonGia.BorderStyle = BorderStyle.Fixed3D;
            lbl_DonGia.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DonGia.ForeColor = SystemColors.ActiveCaptionText;
            lbl_DonGia.Location = new Point(523, 29);
            lbl_DonGia.Name = "lbl_DonGia";
            lbl_DonGia.Size = new Size(140, 35);
            lbl_DonGia.TabIndex = 2;
            lbl_DonGia.Click += label11_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(192, 192, 0);
            label13.Location = new Point(788, 29);
            label13.Name = "label13";
            label13.Size = new Size(107, 20);
            label13.TabIndex = 2;
            label13.Text = "Thành Tiền : ";
            label13.Click += label11_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(192, 192, 0);
            label11.Location = new Point(430, 30);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 2;
            label11.Text = "Đơn Giá :";
            label11.Click += label11_Click;
            // 
            // lbl_TongNgayThueXe
            // 
            lbl_TongNgayThueXe.BorderStyle = BorderStyle.Fixed3D;
            lbl_TongNgayThueXe.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TongNgayThueXe.ForeColor = SystemColors.ActiveCaptionText;
            lbl_TongNgayThueXe.Location = new Point(143, 30);
            lbl_TongNgayThueXe.Name = "lbl_TongNgayThueXe";
            lbl_TongNgayThueXe.Size = new Size(75, 34);
            lbl_TongNgayThueXe.TabIndex = 1;
            lbl_TongNgayThueXe.Click += lbl_TongNgayThueXe_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(192, 192, 0);
            label8.Location = new Point(1, 37);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 0;
            label8.Text = "Tổng Ngày Thuê :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(8, 599);
            label10.Name = "label10";
            label10.Size = new Size(108, 23);
            label10.TabIndex = 4;
            label10.Text = "Tổng Tiền :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 599);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 22);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(453, 610);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 6;
            button1.Text = "Lưu Hóa Đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(453, 645);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 6;
            button2.Text = "Thêm Hóa Đơn ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(677, 610);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 6;
            button3.Text = "In Hóa Đơn";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(677, 646);
            button4.Name = "button4";
            button4.Size = new Size(127, 29);
            button4.TabIndex = 6;
            button4.Text = "Xóa Hóa Đơn";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(1131, 12);
            button5.Name = "button5";
            button5.Size = new Size(97, 64);
            button5.TabIndex = 7;
            button5.Text = "Thoát Chương Trình";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btn_CapNhap
            // 
            btn_CapNhap.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CapNhap.ForeColor = Color.Blue;
            btn_CapNhap.Location = new Point(317, 595);
            btn_CapNhap.Name = "btn_CapNhap";
            btn_CapNhap.Size = new Size(96, 29);
            btn_CapNhap.TabIndex = 6;
            btn_CapNhap.Text = "Cập Nhập";
            btn_CapNhap.UseVisualStyleBackColor = true;
            btn_CapNhap.Click += btn_CapNhap_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1240, 735);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_CapNhap);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Box1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "HoaDon";
            Box1.ResumeLayout(false);
            Box1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Box1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox txt_MaHoadon;
        private TextBox txt_BienSoXe;
        private TextBox txt_TenKhachHang;
        private ComboBox cb_HangXe;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Label label11;
        private Label lbl_TongNgayThueXe;
        private Label lbl_ThanhTien;
        private Label lbl_DonGia;
        private Label label13;
        private Label label10;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListView listHoaDon;
        private ColumnHeader cMaHoaDon;
        private ColumnHeader cKhachHang;
        private ColumnHeader cBienSoXe;
        private ColumnHeader cTongNgayThue;
        private ColumnHeader cDonGia;
        private ColumnHeader cThanhTien;
        private Button btn_CapNhap;
        private ColumnHeader cHangXe;
    }
}