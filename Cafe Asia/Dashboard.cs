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
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_allfoods_Click(object sender, EventArgs e)
        {
           
        }

        private void link_LogOut_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            this.Hide();
            L1.Show();
        }

        private void btn_allfoods_Click_1(object sender, EventArgs e)
        {
            All_Foods AF1 = new All_Foods();
            this.Hide();
            AF1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Contact_Us CU1 = new Contact_Us();
            this.Hide();
            CU1.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard A1 = new Admin_Dashboard();
            this.Hide();
            A1.Show();
        }
    }
}
