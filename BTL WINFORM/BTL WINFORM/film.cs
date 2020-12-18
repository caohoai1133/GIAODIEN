using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Entity.Model.DescendantBuilding;

namespace BTL_WINFORM
{
    public partial class film : Form
    {
        public film()
        {
            InitializeComponent();
        }

        private void film_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khangDataSet2.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter1.Fill(this.khangDataSet2.Table_2);
            // TODO: This line of code loads data into the 'khangDataSet1.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.khangDataSet1.Table_2);

        }

        private void testGrid_Load(object sender, EventArgs e)
        {   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chon F = new chon();
            F.Visible = true;
            this.Visible = false;
        }
    }
}
