using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WINFORM
{
    public partial class chon : Form
    {
        public chon()
        {
            InitializeComponent();
        }

        private void DX_Click(object sender, EventArgs e)
        {
            LOGIN f = new LOGIN();
            f.Show();
            this.Visible = false;
        }

        private void BANVE_Click(object sender, EventArgs e)
        {
            BANVE F = new BANVE();
            F.Show();
            this.Visible = false;
        }

        private void LICHCHIEU_Click(object sender, EventArgs e)
        {
            film f = new film();
            f.Show();
            this.Visible = false;
        }

        private void NHANVIEN_Click(object sender, EventArgs e)
        {
            QUANLYNV F = new QUANLYNV();
            F.Visible = true;
            this.Visible = false;
        }

        private void RAP_Click(object sender, EventArgs e)
        {
            QLRAP F = new QLRAP();
            F.Visible = true;
            this.Visible = false;
        }

        private void THONGKE_Click(object sender, EventArgs e)
        {
            THONGKE  F = new THONGKE();
            F.Visible = true;
            this.Visible = false;
        }
    }
}
