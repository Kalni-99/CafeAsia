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
    public partial class Desserts : MetroFramework.Forms.MetroForm
    {
        public Desserts()
        {
            InitializeComponent();
        }

        Class1 c1 = new Class1();
        database db = new database();

        private void Desserts_Load(object sender, EventArgs e)
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
            if (choco_qty.Text != "0" && choco_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(choco_qty.Value);
            c1.food_name = "Chocolate Pudding ";
            c1.unitprice = 200;
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
                if (buttrscotch_qty.Text != "0" && buttrscotch_qty.Text != "")
                {
                    c1.quantity = Convert.ToDouble(buttrscotch_qty.Text);
                    c1.food_name = "Butterscotch Pudding";
                    c1.unitprice = 300;
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
            if (cheeescake_qty.Text != "0" && cheeescake_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(cheeescake_qty.Text);
            c1.food_name = "Cheesecake";
            c1.unitprice = 450;
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
         if (fruitart_qty.Text != "0" && fruitart_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(fruitart_qty.Text);
            c1.food_name = "Fruit Tart";
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

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
          if (brownies_qty.Text != "0" && brownies_qty.Text != "")
           {
            c1.quantity = Convert.ToDouble(brownies_qty.Text);
            c1.food_name = "Brownies";
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

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
        if (watalapn_qty.Text != "0" && watalapn_qty.Text != "")
       {
            c1.quantity = Convert.ToDouble(watalapn_qty.Text);
            c1.food_name = "Watalappan";
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

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
        if (fruitjelly_qty.Text != "0" && fruitjelly_qty.Text != "")
         {
            c1.quantity = Convert.ToDouble(fruitjelly_qty.Text);
            c1.food_name = "Fruit Jelly";
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

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
          if (mango_qty.Text != "0" && mango_qty.Text != "")
             {
                                            c1.quantity = Convert.ToDouble(mango_qty.Text);
              c1.food_name = "Mango with Chia";
              c1.unitprice = 200;
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

        private void guna2NumericUpDown7_ValueChanged(object sender, EventArgs e)
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
