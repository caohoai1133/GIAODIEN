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
    public partial class QUANLYNV : Form
    {
        public QUANLYNV()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chon F = new chon();
            F.Visible = true;
            this.Visible = false;
        }
    }
}
