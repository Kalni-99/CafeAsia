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
    public partial class IG_QR_code : MetroFramework.Forms.MetroForm
    {
        public IG_QR_code()
        {
            InitializeComponent();
        }

        private void IG_QR_code_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            Contact_Us CU1 = new Contact_Us();
            this.Hide();
            CU1.Show();
        }
    }
}
