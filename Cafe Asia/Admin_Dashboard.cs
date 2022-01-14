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
    public partial class Admin_Dashboard : MetroFramework.Forms.MetroForm
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_foods_Click(object sender, EventArgs e)
        {
            Add_Update_Delete_Foods AUD1 = new Add_Update_Delete_Foods();
            this.Hide();
            AUD1.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Item_List_Report IL1 = new Item_List_Report();
            this.Hide();
            IL1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Customer_Report C1 = new Customer_Report();
            this.Hide();
            C1.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Sales_Report SR1 = new Sales_Report();
            this.Hide();
            SR1.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            sms S1 = new sms();
            this.Hide();
            S1.Show();
        }

        private void link_LogOut_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            this.Hide();
            L1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Email e1 = new Email();
            this.Hide();
            e1.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_qr_Click(object sender, EventArgs e)
        {

            QR_code c1 = new QR_code();
            this.Hide();
            c1.ShowDialog();
        }
    }
}
