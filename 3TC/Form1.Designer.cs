namespace _3TC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            dtout = new DateTimePicker();
            dtin = new DateTimePicker();
            txttenxe = new TextBox();
            txtmaxe = new TextBox();
            txtbiensoxe = new TextBox();
            txttenloaixe = new TextBox();
            txtmaloaixe = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            listView1 = new ListView();
            STT = new ColumnHeader();
            MaLX = new ColumnHeader();
            TenLX = new ColumnHeader();
            MAxe = new ColumnHeader();
            Tenxe = new ColumnHeader();
            BienSoxe = new ColumnHeader();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtout);
            groupBox1.Controls.Add(dtin);
            groupBox1.Controls.Add(txttenxe);
            groupBox1.Controls.Add(txtmaxe);
            groupBox1.Controls.Add(txtbiensoxe);
            groupBox1.Controls.Add(txttenloaixe);
            groupBox1.Controls.Add(txtmaloaixe);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin ";
            // 
            // button1
            // 
            button1.Location = new Point(229, 314);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 4;
            button1.Text = "Nhập Xe";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtout
            // 
            dtout.Location = new Point(422, 224);
            dtout.Name = "dtout";
            dtout.Size = new Size(250, 33);
            dtout.TabIndex = 3;
            // 
            // dtin
            // 
            dtin.Location = new Point(422, 160);
            dtin.Name = "dtin";
            dtin.Size = new Size(250, 33);
            dtin.TabIndex = 3;
            // 
            // txttenxe
            // 
            txttenxe.Location = new Point(133, 227);
            txttenxe.Name = "txttenxe";
            txttenxe.Size = new Size(152, 33);
            txttenxe.TabIndex = 2;
            // 
            // txtmaxe
            // 
            txtmaxe.Location = new Point(133, 159);
            txtmaxe.Name = "txtmaxe";
            txtmaxe.Size = new Size(152, 33);
            txtmaxe.TabIndex = 2;
            txtmaxe.TextChanged += textBox3_TextChanged;
            // 
            // txtbiensoxe
            // 
            txtbiensoxe.Location = new Point(422, 104);
            txtbiensoxe.Name = "txtbiensoxe";
            txtbiensoxe.Size = new Size(194, 33);
            txtbiensoxe.TabIndex = 2;
            txtbiensoxe.KeyPress += txtbiensoxe_KeyPress;
            // 
            // txttenloaixe
            // 
            txttenloaixe.Location = new Point(133, 100);
            txttenloaixe.Name = "txttenloaixe";
            txttenloaixe.Size = new Size(152, 33);
            txttenloaixe.TabIndex = 2;
            // 
            // txtmaloaixe
            // 
            txtmaloaixe.Location = new Point(133, 42);
            txtmaloaixe.Name = "txtmaloaixe";
            txtmaloaixe.Size = new Size(152, 33);
            txtmaloaixe.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 234);
            label6.Name = "label6";
            label6.Size = new Size(84, 26);
            label6.TabIndex = 1;
            label6.Text = "Ngày ra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 111);
            label7.Name = "label7";
            label7.Size = new Size(123, 26);
            label7.TabIndex = 0;
            label7.Text = "Biển Số Xe ";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 166);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 0;
            label5.Text = "Ngày vào ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(127, 26);
            label4.TabIndex = 1;
            label4.Text = "Tên Loại Xe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 49);
            label3.Name = "label3";
            label3.Size = new Size(126, 26);
            label3.TabIndex = 0;
            label3.Text = "Mã Loại Xe ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 234);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 1;
            label2.Text = "Tên Xe";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 166);
            label1.Name = "label1";
            label1.Size = new Size(73, 26);
            label1.TabIndex = 0;
            label1.Text = "Mã Xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(32, 445);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Xe";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vinfast", "Mazda", "Lexus", "Lambogini", "Ferrari", "Honda", "BMW", "Mercedes-Benz", "Porsche ", "Mclaren" });
            comboBox1.Location = new Point(146, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 33);
            comboBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(229, 210);
            button2.Name = "button2";
            button2.Size = new Size(131, 44);
            button2.TabIndex = 4;
            button2.Text = "Xuất Xe";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(listView1);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(737, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 749);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Xuất Thông Tin Xe ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(202, 49);
            label8.Name = "label8";
            label8.Size = new Size(76, 40);
            label8.TabIndex = 6;
            label8.Text = "3TC";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { STT, MaLX, TenLX, MAxe, Tenxe, BienSoxe });
            listView1.GridLines = true;
            listView1.Location = new Point(24, 183);
            listView1.Name = "listView1";
            listView1.Size = new Size(452, 549);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // MaLX
            // 
            MaLX.Text = "MaLX";
            // 
            // TenLX
            // 
            TenLX.Text = "TenLX";
            // 
            // MAxe
            // 
            MAxe.Text = "Maxe";
            // 
            // Tenxe
            // 
            Tenxe.Text = "TenXe";
            // 
            // BienSoxe
            // 
            BienSoxe.Text = "BienSoXe";
            // 
            // button4
            // 
            button4.Location = new Point(309, 124);
            button4.Name = "button4";
            button4.Size = new Size(131, 44);
            button4.TabIndex = 4;
            button4.Text = "Nhập Xe";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(48, 124);
            button3.Name = "button3";
            button3.Size = new Size(131, 44);
            button3.TabIndex = 4;
            button3.Text = "Nhập Xe";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 773);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "3TC Quản Lý Xe ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txttenxe;
        private TextBox txtmaxe;
        private TextBox txttenloaixe;
        private TextBox txtmaloaixe;
        private Label label7;
        private DateTimePicker dtout;
        private DateTimePicker dtin;
        private TextBox txtbiensoxe;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader MaLX;
        private ColumnHeader TenLX;
        private ColumnHeader MAxe;
        private ColumnHeader Tenxe;
        private ColumnHeader BienSoxe;
        private Button button4;
        private Button button3;
        private Label label8;
        private ColumnHeader STT;
    }
}