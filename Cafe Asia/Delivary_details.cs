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
using System.IO;
using System.Net;
namespace Cafe_Asia
{
    public partial class Delivary_details : Form
    {
        public Delivary_details()
        {
            InitializeComponent();
        }

        private void Delivary_details_Load(object sender, EventArgs e)
        {

        }
        database db = new database();
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contactno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_confirmpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into delivary values ('" + txt_fname.Text + "', '" + txt_lname.Text + "', '" + txt_addr1.Text + "', '" + txt_addr2.Text + "', '" + txt_city.Text + "','" + txt_contact.Text + "','" + txt_email.Text + "') ";
                int i = db.save_update_delete(query);
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WebClient client = new WebClient();
                // client.Headers.Add("user - agent", "Mozilla / 4.0(compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                client.QueryString.Add("id", "94772582766");
                client.QueryString.Add("pw", "4858");
                client.QueryString.Add("to", "94770075385");
                client.QueryString.Add("text", "The order you placed @cafe asia  will be deliverd soon");
                string baseurl = "http://www.textit.biz/sendmsg";
                Stream data = client.OpenRead(baseurl);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                data.Close();
                reader.Close();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_fname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fname.Text) || txt_fname.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                txt_fname.Focus();
                errorProvider1.SetError(txt_fname, "cannot be empty or contain numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_fname, null);

            }

        }

        private void txt_lname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lname.Text) || txt_lname.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                txt_lname.Focus();
                errorProvider1.SetError(txt_lname, "cannot be empty or contain numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_lname, null);

            }
        }

        private void txt_addr1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_addr1.Text))
            {
                e.Cancel = true;
                txt_addr1.Focus();
                errorProvider1.SetError(txt_addr1, "cannot be empty ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_addr1, null);

            }
        }

        private void txt_addr2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_addr2.Text) )
            {
                e.Cancel = true;
                txt_addr2.Focus();
                errorProvider1.SetError(txt_addr2, "cannot be empty ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_addr2, null);

            }
        }

        private void txt_city_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_city.Text) )
            {
                e.Cancel = true;
                txt_city.Focus();
                errorProvider1.SetError(txt_city, "cannot be empty ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_city, null);

            }

        }

        private void txt_contact_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_contact.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
            {
                e.Cancel = true;
                txt_contact.Focus();
                errorProvider1.SetError(txt_contact, "contact number must have 10 numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_contact, null);

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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            payment P1 = new payment();
            this.Hide();
            P1.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();  
        }
    }
}
