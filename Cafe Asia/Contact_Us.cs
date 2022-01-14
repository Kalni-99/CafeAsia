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
    public partial class Contact_Us : MetroFramework.Forms.MetroForm
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void Contact_Us_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            Dashboard D1 = new Dashboard();
            this.Hide();
            D1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IG_QR_code IG1 = new IG_QR_code();
            this. Hide();
            IG1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gmail_QR_code G1 = new Gmail_QR_code();
            this.Hide();
            G1.Show();
        }
    }
}
