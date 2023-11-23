using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3TC
{
    public partial class quanlyxe : Form
    {
        public quanlyxe()
        {
            InitializeComponent();
        }

        private void TimXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timxe(object sender, EventArgs e)
        {
            TimXe.Text = "";
        }

        private void CLose(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem XE;

            //định nghĩa các subnet và thuộc tính 
            ListViewItem.ListViewSubItem Khachhang, bienso, hangxe, ngayvao;

            XE = new ListViewItem();

            Khachhang = new ListViewItem.ListViewSubItem();
            Khachhang.Text = txtkh.Text;

            bienso = new ListViewItem.ListViewSubItem();
            bienso.Text = txtbiensoxe.Text;

            hangxe = new ListViewItem.ListViewSubItem();
            hangxe.Text = cbhangxe.Text;

            ngayvao = new ListViewItem.ListViewSubItem();
            ngayvao.Text = dtangayvao.Text;

            //add subnet và listviewitem tên , năm sinh , masv
            XE.SubItems.Add(Khachhang);
            XE.SubItems.Add(bienso);
            XE.SubItems.Add(hangxe);
            XE.SubItems.Add(ngayvao);
            lstbaixe.Items.Add(XE);

            int index = 1;
            foreach (ListViewItem item in lstbaixe.Items)
            {
                item.Text = index.ToString();
                index++;
            }
        }

        private void button3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            this.Hide();
            var frm = new DangNhap();
            frm.ShowDialog();
        }

        private void quanlyxe_Load(object sender, EventArgs e)
        {
           
        }
        private void lstbaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
