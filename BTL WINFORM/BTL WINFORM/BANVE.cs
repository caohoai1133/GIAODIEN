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
    public partial class BANVE : Form
    {
        public BANVE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chon F = new chon();
            F.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
            textBox2.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime idate;
            idate = dateTimePicker1.Value;
            textBox3.Text = dateTimePicker1.Text;
            textBox3.Enabled = false;
        }

        private void BANVE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khangDataSet.PHIM' table. You can move, or remove it, as needed.
            this.pHIMTableAdapter.Fill(this.khangDataSet.PHIM);
            List<Button> buttons;
          
            buttons = new List<Button>();
            for (int i = 0; i < 100; i++)
            {
                TabControl t = new TabControl();
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                flowLayoutPanel1.Controls.Add(b);
                b.Click += new EventHandler(bt_click);
                
                t.Click += new EventHandler(rap_click);                   
            }
            for (int i = 0; i < 100; i++)
            {
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                TabControl t = new TabControl();
                b.Click += new EventHandler(bt_click);
                flowLayoutPanel2.Controls.Add(b);
                t.Click += new EventHandler(rap_click);
            }
            for (int i = 0; i < 100; i++)
            {
                TabControl t = new TabControl(); 
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                t.Click += new EventHandler(rap_click);
                b.Click += new EventHandler(bt_click);
                flowLayoutPanel3.Controls.Add(b);

            }
            for (int i = 0; i < 100; i++)
            {
                TabControl t = new TabControl();
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                t.Click += new EventHandler(rap_click);
                b.Click += new EventHandler(bt_click);
                flowLayoutPanel4.Controls.Add(b);

            }
            for (int i = 0; i < 100; i++)
            {
                TabControl t = new TabControl();
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                t.Click += new EventHandler(rap_click);
                b.Click += new EventHandler(bt_click);
                flowLayoutPanel5.Controls.Add(b);

            }
            for (int i = 0; i < 100; i++)
            {
                TabControl t = new TabControl();
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                t.Click += new EventHandler(rap_click);
                b.Click += new EventHandler(bt_click);
                flowLayoutPanel6.Controls.Add(b);

            }
            for (int i = 0; i < 100; i++)
            {
                TabControl t = new TabControl();
                Button b = new Button();
                b.Text = "G " + (i + 1);
                b.Width = 40;
                b.Top = 0;
                b.Left = i * 50;
                buttons.Add(b);
                t.Click += new EventHandler(rap_click);
                b.Click += new EventHandler(bt_click);
                flowLayoutPanel7.Controls.Add(b);

            }



        }
        private void rap_click(object sender, EventArgs e)
        {

            TabControl bn = (TabControl)sender;

            textBox6.Text = bn.Text;
            

        }
        private void bt_click (object sender ,EventArgs e)
        {
           
            Button btn = (Button)sender;
            
            textBox5.Text = btn.Text;
            textBox5.Enabled = false;

        }



        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void DK_Click(object sender, EventArgs e)
        {
            DKKHTT F = new DKKHTT();
            F.Show();
            this.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            



        }
    }
}
