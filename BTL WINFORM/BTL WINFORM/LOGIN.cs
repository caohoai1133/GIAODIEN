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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            { textBox2.UseSystemPasswordChar = true; }
            else
            { textBox2.UseSystemPasswordChar = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chon f= new chon();
            f.Show();
            this.Visible = false;
        }
    }
    }
