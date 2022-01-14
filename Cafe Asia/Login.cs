kausing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Asia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        database db = new database();
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //string constr = "Data Source=KALANI\MSSQLSERVER01;Initial Catalog=Cafe_Asia;Integrated Security=True";
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Cafe_Asia; Integrated Security = True");
            SqlDataAdapter da= new SqlDataAdapter("select count(*) from register where username='" + txt_username.Text + "' and password='" + txt_pwd.Text + "' ",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
         
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();

                string q = "delete from food";
                db.save_update_delete(q);

                Dashboard d1 = new Dashboard();
                d1.ShowDialog();
            }
            else if(txt_username.Text=="admin" && txt_pwd.Text=="admin")
            {
                Admin_Dashboard AD1 = new Admin_Dashboard();
                this.Hide();
                AD1.Show();
            }
            else
            {
                MessageBox.Show("please check your username and password again", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r1 = new Registration();
            r1.ShowDialog();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
