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
    public partial class All_Foods : MetroFramework.Forms.MetroForm
    {
        public All_Foods()
        {
            InitializeComponent();
        }

        private void All_Foods_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            Dashboard D1 = new Dashboard();
            this.Hide();
            D1.Show();
        }

        private void btn_foods_Click(object sender, EventArgs e)
        {
            Foods F1 = new Foods();
            this.Hide();
            F1.Show();
        }

        private void btn_desserts_Click(object sender, EventArgs e)
        {
            Desserts D1 = new Desserts();
            this.Hide();
            D1.Show();
        }

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            Drinks DR1 = new Drinks();
            this.Hide();
            DR1.Show();
        }

        private void btn_snacks_Click(object sender, EventArgs e)
        {
            Snacks S1 = new Snacks();
            this.Hide();
            S1.Show();
        }
    }
}
