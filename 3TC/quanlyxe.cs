using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
        }
    }
}
