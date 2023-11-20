namespace _3TC
{
    partial class quanlyxe
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            dtangayvao = new DateTimePicker();
            cbhangxe = new ComboBox();
            txtbiensoxe = new TextBox();
            txtkh = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TimXe = new TextBox();
            button3 = new Button();
            lstbaixe = new ListView();
            CSoTT = new ColumnHeader();
            CTenKhach = new ColumnHeader();
            CSoXe = new ColumnHeader();
            CHangXe = new ColumnHeader();
            CNgayVao = new ColumnHeader();
            CNgayRa = new ColumnHeader();
            btnexit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtangayvao);
            groupBox1.Controls.Add(cbhangxe);
            groupBox1.Controls.Add(txtbiensoxe);
            groupBox1.Controls.Add(txtkh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 562);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "NHẬP XE";
            // 
            // button1
            // 
            button1.Location = new Point(146, 293);
            button1.Name = "button1";
            button1.Size = new Size(121, 59);
            button1.TabIndex = 10;
            button1.Text = "NHẬP XE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtangayvao
            // 
            dtangayvao.CustomFormat = "dd/MM/yyyy";
            dtangayvao.Format = DateTimePickerFormat.Custom;
            dtangayvao.Location = new Point(146, 230);
            dtangayvao.Name = "dtangayvao";
            dtangayvao.Size = new Size(228, 31);
            dtangayvao.TabIndex = 9;
            // 
            // cbhangxe
            // 
            cbhangxe.FormattingEnabled = true;
            cbhangxe.Items.AddRange(new object[] { "VinFast", "Volkswagen", "Toyota", "Mercedes-Benz", "BMW", "Honda", "Hyundai", "Stellantis", "Ford", "SAIC", "General Motors", "Suzuki", "Fiat" });
            cbhangxe.Location = new Point(146, 175);
            cbhangxe.Name = "cbhangxe";
            cbhangxe.Size = new Size(228, 33);
            cbhangxe.TabIndex = 8;
            // 
            // txtbiensoxe
            // 
            txtbiensoxe.Location = new Point(146, 121);
            txtbiensoxe.Name = "txtbiensoxe";
            txtbiensoxe.Size = new Size(228, 31);
            txtbiensoxe.TabIndex = 7;
            // 
            // txtkh
            // 
            txtkh.Location = new Point(146, 69);
            txtkh.Name = "txtkh";
            txtkh.Size = new Size(228, 31);
            txtkh.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 127);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 3;
            label4.Text = "Biển Số Xe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 183);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Hãng Xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 236);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày Vào:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 75);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TimXe);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(lstbaixe);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(508, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(599, 750);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "XUẤT XE";
            // 
            // TimXe
            // 
            TimXe.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TimXe.Location = new Point(27, 57);
            TimXe.Name = "TimXe";
            TimXe.Size = new Size(199, 31);
            TimXe.TabIndex = 11;
            TimXe.Text = "Nhập Tên Khách";
            TimXe.Click += Timxe;
            TimXe.TextChanged += TimXe_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(264, 51);
            button3.Name = "button3";
            button3.Size = new Size(94, 37);
            button3.TabIndex = 2;
            button3.Text = "TÌM XE";
            button3.UseVisualStyleBackColor = true;
            button3.TextChanged += button3_TextChanged;
            button3.Click += button3_Click;
            // 
            // lstbaixe
            // 
            lstbaixe.Columns.AddRange(new ColumnHeader[] { CSoTT, CTenKhach, CSoXe, CHangXe, CNgayVao, CNgayRa });
            lstbaixe.FullRowSelect = true;
            lstbaixe.GridLines = true;
            lstbaixe.Location = new Point(9, 127);
            lstbaixe.Name = "lstbaixe";
            lstbaixe.Size = new Size(584, 616);
            lstbaixe.TabIndex = 0;
            lstbaixe.UseCompatibleStateImageBehavior = false;
            lstbaixe.View = View.Details;
            lstbaixe.SelectedIndexChanged += lstbaixe_SelectedIndexChanged;
            // 
            // CSoTT
            // 
            CSoTT.Text = "Số TT";
            // 
            // CTenKhach
            // 
            CTenKhach.Text = "Tên Khách";
            CTenKhach.Width = 105;
            // 
            // CSoXe
            // 
            CSoXe.Text = "Số Xe";
            CSoXe.Width = 75;
            // 
            // CHangXe
            // 
            CHangXe.Text = "Hãng Xe";
            CHangXe.Width = 90;
            // 
            // CNgayVao
            // 
            CNgayVao.Text = "Ngày Vào";
            CNgayVao.Width = 100;
            // 
            // CNgayRa
            // 
            CNgayRa.Text = "Ngày Ra";
            CNgayRa.Width = 95;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1013, 761);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 11;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // quanlyxe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 794);
            Controls.Add(btnexit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "quanlyxe";
            Text = "QUẢN LÝ XE";
            FormClosing += CLose;
            Load += quanlyxe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbhangxe;
        private TextBox txtbiensoxe;
        private TextBox txtkh;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lstbaixe;
        private Button button1;
        private DateTimePicker dtangayvao;
        private TextBox TimXe;
        private Button button3;
        private ColumnHeader CSoTT;
        private ColumnHeader CTenKhach;
        private ColumnHeader CSoXe;
        private ColumnHeader CHangXe;
        private ColumnHeader CNgayVao;
        private ColumnHeader CNgayRa;
        private Button btnexit;
    }
}