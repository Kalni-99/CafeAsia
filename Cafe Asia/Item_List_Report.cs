using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Asia
{
    public partial class Item_List_Report : MetroFramework.Forms.MetroForm
    {
        public Item_List_Report()
        {
            InitializeComponent();
        }

        private void Item_List_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Item_List.food' table. You can move, or remove it, as needed.
            this.fooditemTableAdapter.Fill(this.DS_Item_List.fooditem);

            this.reportViewer1.RefreshReport();
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            Admin_Dashboard AD1 = new Admin_Dashboard();
            this.Hide();
            AD1.ShowDialog();
        }
    }
}
