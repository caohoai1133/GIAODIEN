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
    public partial class CHAO : Form
    {
        public CHAO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN f = new LOGIN();
            
            f.Show();
            this.Visible= false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LOGIN H = new LOGIN();
            H.Show();
            this.Visible = false;
        }
    }
}
