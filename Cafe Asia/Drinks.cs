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
    public partial class Drinks : MetroFramework.Forms.MetroForm
    {
        public Drinks()
        {
            InitializeComponent();
        }

        Class1 c1 = new Class1();
        database db = new database();

        private void Drinks_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (banana_qty.Text != "0" &&banana_qty.Text != "")
            {
                c1.quantity = Convert.ToDouble(banana_qty.Text);
            c1.food_name = "Banana Strawberry Milkshake";
            c1.unitprice = 700;
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
           if (carrot_qty.Text != "0" && carrot_qty.Text != "")
               
           {
           c1.quantity = Convert.ToDouble(carrot_qty.Text);
            c1.food_name = "Carrot Milkshake";
            c1.unitprice = 250;
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
         if (chocomilkshake_qty.Text != "0" && chocomilkshake_qty.Text != "")
           {
            c1.quantity = Convert.ToDouble(chocomilkshake_qty.Text);
            c1.food_name = "Chocolate Milkshake";
            c1.unitprice = 600;
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
         if (strawberry_qty.Text != "0" && strawberry_qty.Text != "")
       {
           c1.quantity = Convert.ToDouble(strawberry_qty.Text);
            c1.food_name = "Strawberry Milkshake";
            c1.unitprice = 400;
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
            if (vegmilkshake_qty.Text != "0" && vegmilkshake_qty.Text != "")
           {
            c1.quantity = Convert.ToDouble(vegmilkshake_qty.Text);
            c1.food_name = "Veg Milkshake";
            c1.unitprice = 150;
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
        if (peanutbutter_qty.Text != "0" && peanutbutter_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(peanutbutter_qty.Text);
            c1.food_name = "Peanut Butter Milkshake";
            c1.unitprice = 800;
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
        if (cherry_qty.Text != "0" && cherry_qty.Text != "")
        {
            c1.quantity = Convert.ToDouble(cherry_qty.Text);
            c1.food_name = "Cherry Milkshake";
            c1.unitprice = 750;
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

          if (dracula_qty.Text != "0" && dracula_qty.Text != "")
          {
            c1.quantity = Convert.ToDouble(dracula_qty.Text);
            c1.food_name = "Dracula Freakshake";
            c1.unitprice = 500;
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
        }
    }
}
