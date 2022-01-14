using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Cafe_Asia
{
    public partial class Email : Form
    {
        NetworkCredential login;
        MailMessage msg;
        SmtpClient client;
        public Email()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txt_username.Text, txt_password.Text);
            client = new SmtpClient(txt_smtp.Text);
            client.Port = Convert.ToInt32(txt_port.Text);
            client.EnableSsl = chk_ssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txt_username.Text + txt_smtp.Text.Replace("Smtp", "@"), "Cafe Asia", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txt_to.Text));
            if (!string.IsNullOrEmpty(txt_cc.Text))
                msg.To.Add(new MailAddress(txt_cc.Text));
             msg.Subject = txt_subject.Text;
            msg.Body = txt_message.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(sendcompletedcallback);
            string userstate = "sending...";
            client.SendAsync(msg, userstate);

        }
        private static void sendcompletedcallback(object sender,AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send cancelled ", e.UserState), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1} ", e.UserState,e.Error), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("you message have been succefully sent", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard ad1 = new Admin_Dashboard();
            ad1.ShowDialog();
        }
    }
}
