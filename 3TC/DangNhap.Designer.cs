namespace _3TC
{
    partial class DangNhap
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
            lbltaikhoan = new TextBox();
            lblmatkhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btndangnhap = new Button();
            SuspendLayout();
            // 
            // lbltaikhoan
            // 
            lbltaikhoan.Location = new Point(155, 108);
            lbltaikhoan.Name = "lbltaikhoan";
            lbltaikhoan.Size = new Size(191, 27);
            lbltaikhoan.TabIndex = 0;
            lbltaikhoan.TextChanged += textBox1_TextChanged;
            // 
            // lblmatkhau
            // 
            lblmatkhau.Location = new Point(155, 167);
            lblmatkhau.Name = "lblmatkhau";
            lblmatkhau.PasswordChar = '*';
            lblmatkhau.Size = new Size(191, 27);
            lblmatkhau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 110);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 169);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu:";
            // 
            // btndangnhap
            // 
            btndangnhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndangnhap.Location = new Point(100, 226);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(191, 54);
            btndangnhap.TabIndex = 4;
            btndangnhap.Text = "ĐĂNG NHẬP";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += button1_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(394, 481);
            Controls.Add(btndangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblmatkhau);
            Controls.Add(lbltaikhoan);
            Name = "DangNhap";
            Text = "DangNhap";
            FormClosing += Dangnhao;
            Load += DangNhap_Load;
            KeyDown += DangNhap_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lbltaikhoan;
        private TextBox lblmatkhau;
        private Label label1;
        private Label label2;
        private Button btndangnhap;
    }
}