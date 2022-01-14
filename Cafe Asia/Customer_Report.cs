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
    public partial class Customer_Report : MetroFramework.Forms.MetroForm
    {
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Customer.delivary' table. You can move, or remove it, as needed.
            //this.delivaryTableAdapter.Fill(this.DS_Customer.delivary);
            // TODO: This line of code loads data into the 'DS_Customer.register' table. You can move, or remove it, as needed.
            //this.registerTableAdapter.Fill(this.DS_Customer.register);

            this.reportViewer1.RefreshReport();
           
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            Admin_Dashboard AD1 = new Admin_Dashboard();
            this.Hide();
            AD1.Show();
        }
    }
}
