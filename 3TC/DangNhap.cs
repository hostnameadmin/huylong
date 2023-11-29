using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _3TC
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lbltaikhoan.Text == "huylong" && lblmatkhau.Text == "14122004")
            {
             
                var frm = new quanlyxe();
                frm.ShowDialog();
                this.Close();
            }
            else
               if (lbltaikhoan.Text == "maitrong" && lblmatkhau.Text == "20052004")
            {
             
                var frm = new quanlyxe();
                frm.ShowDialog();
                this.Close();
            }
            else
                if (lbltaikhoan.Text == "tranvi" && lblmatkhau.Text == "17052004")
            {
       
                var frm = new quanlyxe();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR!");
            }

        }

        private void Dangnhao(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}