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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Registration()
        {
            InitializeComponent();
        }
        database db = new database();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into register values ('" + txt_username.Text + "', '" + txt_pwd.Text + "', '" + txt_confirmpwd.Text + "', '" + txt_email.Text + "', '" + txt_contactno.Text + "') ";
                int i = db.save_update_delete(query);
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString() , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //"Please check again"
                db.dbclose();
            }

        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_username.Text))
            {
                e.Cancel = true;
                txt_username.Focus();
                errorProvider1.SetError(txt_username, "please enter your username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_username,null);

            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pwd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_pwd.Text)||txt_pwd.Text.Length>8)
            {
                e.Cancel = true;
                txt_pwd.Focus();
                errorProvider1.SetError(txt_pwd, "please enter your password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_pwd, null);

            }
        }

        private void txt_confirmpwd_Validating(object sender, CancelEventArgs e)
        {
            if (txt_pwd.Text != txt_confirmpwd.Text)
            {
                e.Cancel = true;
                txt_confirmpwd.Focus();
                errorProvider1.SetError(txt_confirmpwd, "Confirm Password must be same as the Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_confirmpwd, null);

            }
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                e.Cancel = true;
                txt_email.Focus();
                errorProvider1.SetError(txt_email, "Enter a valid email. Ex:name@gmail.com");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_email, null);

            }
        }

        private void txt_contactno_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_contactno.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
            {
                e.Cancel = true;
                txt_contactno.Focus();
                errorProvider1.SetError(txt_contactno, "contact number must have 10 numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_contactno, null);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            this.Hide();
            L1.Show();
        }
    }
}
