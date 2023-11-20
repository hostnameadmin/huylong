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




            //ListViewItem XE;

            ////định nghĩa các subnet và thuộc tính 
            //ListViewItem.ListViewSubItem Khachhang, bienso, hangxe, ngayvao;

            //XE = new ListViewItem();

            //Khachhang = new ListViewItem.ListViewSubItem();
            //Khachhang.Text = "Huy Long";

            //bienso = new ListViewItem.ListViewSubItem();
            //bienso.Text = "00000";

            //hangxe = new ListViewItem.ListViewSubItem();
            //hangxe.Text = "BNW";

            //ngayvao = new ListViewItem.ListViewSubItem();
            //ngayvao.Text = "19/11/2023";

            //XE.SubItems.Add(Khachhang);
            //XE.SubItems.Add(bienso);
            //XE.SubItems.Add(hangxe);
            //XE.SubItems.Add(ngayvao);
            //lstbaixe.Items.Add(XE);


            //ListViewItem defaultItem = new ListViewItem("Mục mặc định");

            //// Thêm mục mặc định vào ListView
            //lstbaixe.Items.Add(defaultItem);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            this.Hide();
            var frm = new DangNhap();
            frm.ShowDialog();
        }

        private void quanlyxe_Load(object sender, EventArgs e)
        {
            ListViewItem lbx = new ListViewItem("");
            lbx.SubItems.Add("Huy Long");
            lbx.SubItems.Add("1234");
            lbx.SubItems.Add("BMW");
            lbx.SubItems.Add("19/11/2023");

            lstbaixe.Items.Add(lbx);

            ListViewItem qlbx = new ListViewItem("");
            qlbx.SubItems.Add("Mai Trọng");
            qlbx.SubItems.Add("2345");
            qlbx.SubItems.Add("Ford");
            qlbx.SubItems.Add("19/11/2023");

            lstbaixe.Items.Add(qlbx);

            ListViewItem baixe = new ListViewItem("");
            baixe.SubItems.Add("Trần Vĩ");
            baixe.SubItems.Add("34567");
            baixe.SubItems.Add("Honda");
            baixe.SubItems.Add("19/11/2023");

            lstbaixe.Items.Add(baixe);


        }
        private void sott()
        {
            int index = 1;
            foreach (ListViewItem item in lstbaixe.Items)
            {
                item.Text = index.ToString();
                index++;
            }
        }
        private void lstbaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbaixe.Items.Count > 0)
            {
                ListViewItem lvt = lstbaixe.SelectedItems[0];

                string sott = lvt.SubItems[0].Text;
                string tenkh = lvt.SubItems[1].Text;
                string bienso = lvt.SubItems[2].Text;
                string hangxe = lvt.SubItems[3].Text;
                string ngayvao = lvt.SubItems[4].Text;
            }

        }
    }
}
