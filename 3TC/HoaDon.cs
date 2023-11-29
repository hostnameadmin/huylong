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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHoaDon.Items.Count > 0)
            {
                ListViewItem lvtd = listHoaDon.SelectedItems[0];

                string mahoadon = lvtd.SubItems[0].Text;
                string tenkh = lvtd.SubItems[1].Text;
                string bienso = lvtd.SubItems[2].Text;
                string tong = lvtd.SubItems[3].Text;
                string dongia = lvtd.SubItems[4].Text;
                string thanhtien = lvtd.SubItems[5].Text;

            }
        }

        private void lbl_TongNgayThueXe_Click(object sender, EventArgs e)
        {


        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            ListViewItem HoaDon;

            //định nghĩa các subnet và thuộc tính 
            ListViewItem.ListViewSubItem Khachhang, bienso, hangxe, tongngay, dongia, thanhtien;

            HoaDon = new ListViewItem();

            Khachhang = new ListViewItem.ListViewSubItem();
            Khachhang.Text = txt_TenKhachHang.Text;

            bienso = new ListViewItem.ListViewSubItem();
            bienso.Text = txt_BienSoXe.Text;

            hangxe = new ListViewItem.ListViewSubItem();
            hangxe.Text = cb_HangXe.Text;

            tongngay = new ListViewItem.ListViewSubItem();
            tongngay.Text = lbl_TongNgayThueXe.Text;

            dongia = new ListViewItem.ListViewSubItem();
            dongia.Text = lbl_DonGia.Text;

            thanhtien = new ListViewItem.ListViewSubItem();
            thanhtien.Text = lbl_ThanhTien.Text;

            //add subnet và listviewitem tên , năm sinh , masv
            HoaDon.SubItems.Add(Khachhang);
            HoaDon.SubItems.Add(bienso);
            HoaDon.SubItems.Add(hangxe);
            HoaDon.SubItems.Add(tongngay);
            HoaDon.SubItems.Add(dongia);
            HoaDon.SubItems.Add(thanhtien);

            listHoaDon.Items.Add(HoaDon);


            int index = 1;
            foreach (ListViewItem item in listHoaDon.Items)
            {
                item.Text = index.ToString();
                index++;
            }
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Tính số ngày giữa hai ngày
            TimeSpan difference = endDate - startDate;
            int numberOfDays = (int)(endDate - startDate).TotalDays;

            lbl_TongNgayThueXe.Text = $"{numberOfDays}";
        }

        private void lbl_ThanhTien_Click(object sender, EventArgs e)
        {

        }
    }
}
