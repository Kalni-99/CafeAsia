using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cafe_Asia
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        database db = new database();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
           

            string card_type="";
                if(check_visa.Checked== true)
                {
                    card_type += "visa card";
                }
               else if (check_master.Checked== true)
                {
                    card_type += "master card";
                }
                else if(check_paypal.Checked == true)
                {
                    card_type += "paypal";
                }
                 

                string query = "Insert into payment values ('" + card_type + "', '" + txt_cname.Text + "', '" + txt_cnumber.Text + "', '" + txt_expr.Text + "','"+txt_cvc.Text+"') ";
                int i = db.save_update_delete(query);
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
               MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cname.Text)||txt_cname.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                txt_cname.Focus();
                errorProvider1.SetError(txt_cname, "cannot be empty or contain numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_cname, null);

            }
        }

        private void txt_cnumber_Validating(object sender, CancelEventArgs e)
        {
            if (txt_cnumber.Text.Length !=16 || txt_cnumber.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                txt_cnumber.Focus();
                errorProvider1.SetError(txt_cnumber, "should contain 16 digits");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_cnumber, null);

            }
        }

        private void txt_expr_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_expr.Text, @"^\d{2}/\d{4}$"))
              {
                e.Cancel = true;
                txt_expr.Focus();
                errorProvider1.SetError(txt_expr, "date should be in mm/yyyy format");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_expr, null);

            }
        }

        private void txt_cvc_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_cvc.Text, @"^\d{3}$"))
            {
                e.Cancel = true;
                txt_cvc.Focus();
                errorProvider1.SetError(txt_cvc, "cvc number should be 3 digit");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_cvc, null);

            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            Delivary_details d1 = new Delivary_details();
            this.Hide();
            d1.ShowDialog();
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            my_cart C1 = new my_cart();
            this.Hide();
            C1.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
        }

        private void check_master_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void check_paypal_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void check_visa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
