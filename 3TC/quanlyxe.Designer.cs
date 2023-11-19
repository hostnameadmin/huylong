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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TimXe = new TextBox();
            button3 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            CSoTT = new ColumnHeader();
            CTenKhach = new ColumnHeader();
            CSoXe = new ColumnHeader();
            CHangXe = new ColumnHeader();
            CNgayVao = new ColumnHeader();
            CNgayRa = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox1);
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
            button1.Location = new Point(167, 291);
            button1.Name = "button1";
            button1.Size = new Size(121, 59);
            button1.TabIndex = 10;
            button1.Text = "NHẬP XE";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(146, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "VinFast", "Volkswagen", "Toyota", "Mercedes-Benz", "BMW", "Honda", "Hyundai", "Stellantis", "Ford", "SAIC", "General Motors", "Suzuki", "Fiat" });
            comboBox1.Location = new Point(146, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 33);
            comboBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 31);
            textBox1.TabIndex = 4;
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
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(508, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 562);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "XUẤT XE";
            // 
            // TimXe
            // 
            TimXe.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TimXe.Location = new Point(51, 44);
            TimXe.Name = "TimXe";
            TimXe.Size = new Size(199, 31);
            TimXe.TabIndex = 11;
            TimXe.Text = "Nhập Tên Khách";
            TimXe.Click += Timxe;
            TimXe.TextChanged += TimXe_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(100, 81);
            button3.Name = "button3";
            button3.Size = new Size(94, 37);
            button3.TabIndex = 2;
            button3.Text = "TÌM XE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(307, 30);
            button2.Name = "button2";
            button2.Size = new Size(144, 88);
            button2.TabIndex = 1;
            button2.Text = "XUẤT XE";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CSoTT, CTenKhach, CSoXe, CHangXe, CNgayVao, CNgayRa });
            listView1.Location = new Point(9, 127);
            listView1.Name = "listView1";
            listView1.Size = new Size(442, 429);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CSoTT
            // 
            CSoTT.Text = "Số TT";
            // 
            // CTenKhach
            // 
            CTenKhach.Text = "Tên Khách";
            // 
            // CSoXe
            // 
            CSoXe.Text = "Số Xe";
            // 
            // CHangXe
            // 
            CHangXe.Text = "Hãng Xe";
            // 
            // CNgayVao
            // 
            CNgayVao.Text = "Ngày Vào";
            // 
            // CNgayRa
            // 
            CNgayRa.Text = "Ngày Ra";
            // 
            // quanlyxe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 586);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "quanlyxe";
            Text = "QUẢN LÝ XE";
            FormClosing += CLose;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox TimXe;
        private Button button3;
        private Button button2;
        private ColumnHeader CSoTT;
        private ColumnHeader CTenKhach;
        private ColumnHeader CSoXe;
        private ColumnHeader CHangXe;
        private ColumnHeader CNgayVao;
        private ColumnHeader CNgayRa;
    }
}