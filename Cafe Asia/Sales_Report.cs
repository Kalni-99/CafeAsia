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
    public partial class Sales_Report : MetroFramework.Forms.MetroForm
    {
       

        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Sales.sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.DS_Sales.sales);

            this.reportViewer1.RefreshReport();
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard AD1 = new Admin_Dashboard();
            AD1.ShowDialog();
        }
    }
}
