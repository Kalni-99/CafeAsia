using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shopping_cart_class_library;

namespace Cafe_Asia
{
    public partial class Snacks : MetroFramework.Forms.MetroForm
    {
        public Snacks()
        {
            InitializeComponent();
        }

        Class1 c1 = new Class1();
        database db = new database();

        private void Snacks_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            All_Foods AF1 = new All_Foods();
            this.Hide();
            AF1.Show();
        }

        private void btn_mycart_Click(object sender, EventArgs e)
        {
            my_cart m1 = new my_cart();
            this.Hide();
            m1.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (donuts_qty.Text != "0" && donuts_qty.Text != "")
            {
                c1.quantity = Convert.ToDouble(donuts_qty.Text);
            c1.food_name = "Donuts";
            c1.unitprice = 50;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (kokis_qty.Text != "0" && kokis_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(kokis_qty.Text);
            c1.food_name = "Kokis";
            c1.unitprice = 25;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
           if (lemonpuff_qty.Text != "0" && lemonpuff_qty.Text != "")
           {
            c1.quantity = Convert.ToDouble(lemonpuff_qty.Text);
            c1.food_name = "Lemon Puff";
            c1.unitprice = 100;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
           if (fish_qty.Text != "0" && fish_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(fish_qty.Text);
            c1.food_name = "Fish Rolls";
            c1.unitprice = 35;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
           if (chocofinger_qty.Text != "0" && chocofinger_qty.Text != "")
            {
             c1.quantity = Convert.ToDouble(chocofinger_qty.Text);
            c1.food_name = "Chocolate Fingers ";
            c1.unitprice = 120;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            if (savory_qty.Text != "0" && savory_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(savory_qty.Text);
            c1.food_name = "Savoury Bites";
            c1.unitprice = 180;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
            if (milktofee_qty.Text != "0" && milktofee_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(milktofee_qty.Text);
            c1.food_name = "Milk Toffee";
            c1.unitprice = 10;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
            if (wade_qty.Text != "0" && wade_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(wade_qty.Text);
            c1.food_name = "Wade";
            c1.unitprice = 20;
            c1.CalPrice();
            string query = "Insert into food values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                int i = db.save_update_delete(query);

                string sales = "Insert into sales values ('" + c1.food_name + "', '" + c1.unitprice + "','" + c1.quantity + "','" + c1.price + "')";
                db.save_update_delete(sales);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "minimum quantity need to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void guna2NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
        }
    }
}
