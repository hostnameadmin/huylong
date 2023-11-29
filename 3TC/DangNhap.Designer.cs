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
            lbltaikhoan = new System.Windows.Forms.TextBox();
            lblmatkhau = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbltaikhoan
            // 
            lbltaikhoan.Location = new System.Drawing.Point(155, 108);
            lbltaikhoan.Name = "lbltaikhoan";
            lbltaikhoan.Size = new System.Drawing.Size(191, 27);
            lbltaikhoan.TabIndex = 0;
            lbltaikhoan.TextChanged += this.textBox1_TextChanged;
            // 
            // lblmatkhau
            // 
            lblmatkhau.Location = new System.Drawing.Point(155, 167);
            lblmatkhau.Name = "lblmatkhau";
            lblmatkhau.PasswordChar = '*';
            lblmatkhau.Size = new System.Drawing.Size(191, 27);
            lblmatkhau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(35, 110);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(36, 169);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu:";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(100, 226);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(191, 54);
            button1.TabIndex = 4;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Beige;
            ClientSize = new System.Drawing.Size(394, 481);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblmatkhau);
            Controls.Add(lbltaikhoan);
            Name = "DangNhap";
            Text = "DangNhap";
            FormClosing += Dangnhao;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lbltaikhoan;
        private TextBox lblmatkhau;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}