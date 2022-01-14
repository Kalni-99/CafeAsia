using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace Cafe_Asia
{
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
        }

        private void sms_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            try
            {
                WebClient client = new WebClient();
                // client.Headers.Add("user - agent", "Mozilla / 4.0(compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                client.QueryString.Add("id", txt_username.Text);
                client.QueryString.Add("pw", txt_port.Text);
                client.QueryString.Add("to", txt_number.Text);
                client.QueryString.Add("text", txt_message.Text);
                string baseurl = "http://www.textit.biz/sendmsg";
                Stream data = client.OpenRead(baseurl);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                MetroFramework.MetroMessageBox.Show(this, "Message sent succefully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Close();
                reader.Close();
            }
            catch(FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // return(s);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard ad1 = new Admin_Dashboard();
            ad1.Show();
        }
    }
}
