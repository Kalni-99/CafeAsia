using System;
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
    public partial class Add_Update_Delete_Foods : MetroFramework.Forms.MetroForm
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Cafe_Asia;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;

        public Add_Update_Delete_Foods()
        {
            InitializeComponent();
            displayData();
        }

        private void Add_Update_Delete_Foods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Item_List.food' table. You can move, or remove it, as needed.
            //this.fooditemTableAdapter.Fill(this.dS_Item_List.fooditem);

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard AD1 = new Admin_Dashboard();

            AD1.ShowDialog();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert into fooditem values ('" + txt_name.Text + "', '" + txt_price.Text + "') ", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                displayData();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                lbl_error.Text = "Item Name cannot be blank";
                txt_name.Focus();
            }
            else if (txt_name.Text.Any(char.IsDigit))
            {
                lbl_error.Text = "Item Name cannot have numbers";
                txt_name.Focus();
            }
            else if (txt_price.Text.Any(char.IsLetter))
            {
                lbl_error.Text = "Item Price cannot have letters";
                txt_price.Focus();
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                lbl_error.Text = "Item Price cannot be blank";
                txt_price.Focus();
            }
            else
            {
                lbl_error.Text = "";
            }
        }

        public void displayData()
        {
            con.Open();
            da = new SqlDataAdapter("Select*from fooditem where Item_Name= '" + txt_name.Text + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Update fooditem set  Unit_Price = '" + txt_price.Text + "'where Item_Name= '" + txt_name.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                displayData();


            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                lbl_error.Text = "Item Name cannot be blank";
                txt_name.Focus();
            }
            else if (txt_name.Text.Any(char.IsDigit))
            {
                lbl_error.Text = "Item Name cannot have numbers";
                txt_name.Focus();
            }
            else if (txt_price.Text.Any(char.IsLetter))
            {
                lbl_error.Text = "Item Price cannot have letters";
                txt_price.Focus();
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                lbl_error.Text = "Item Price cannot be blank";
                txt_price.Focus();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from fooditem where Item_Name = '" + txt_name.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                displayData();


            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                lbl_error.Text = "Item Name cannot be blank";
                txt_name.Focus();
            }
            else if (txt_name.Text.Any(char.IsDigit))
            {
                lbl_error.Text = "Item Name cannot have numbers";
                txt_name.Focus();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_price.Clear();
        }
    }
}
