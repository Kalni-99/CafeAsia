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
    public partial class Foods : MetroFramework.Forms.MetroForm
    {
        public Foods()
        {
            InitializeComponent();
        }

        Class1 c1 = new Class1();
        database db = new database();

        
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Foods_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (pasta_qty.Text != "0" && pasta_qty.Text != "")
            {
                c1.quantity = Convert.ToInt32(pasta_qty.Text);
                c1.food_name = "Pasta with Chicken";
                c1.unitprice = 360;
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
            if (naanroti_qty.Text != "0" && naanroti_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(naanroti_qty.Text);
            c1.food_name = "Naan Roti";
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

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
           if (avacado_qty.Text != "0" && avacado_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(avacado_qty.Text);
            c1.food_name = "Avacado Salad";
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

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
             if (chikenbiryani_qty.Text != "0" && chikenbiryani_qty.Text != "")
             {
            c1.quantity = Convert.ToDouble(chikenbiryani_qty.Text);
            c1.food_name = "Chicken Briyani";
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

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            if (vegnoodles_qty.Text != "0" && vegnoodles_qty.Text != "")
           {
            c1.quantity = Convert.ToDouble(vegnoodles_qty.Text);
            c1.food_name = "Veg Noodles";
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

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
            if (submarine_qty.Text != "0" && submarine_qty.Text != "")
           {
            c1.quantity = Convert.ToDouble(submarine_qty.Text);
            c1.food_name = "Cheese Submarine";
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

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
            if (kebabs_qty.Text != "0" && kebabs_qty.Text != "")
            {
            c1.quantity = Convert.ToDouble(kebabs_qty.Text);
            c1.food_name = "Kebabs";
            c1.unitprice = 350;
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

        private void btn_mycart_Click(object sender, EventArgs e)
        {
            this.Hide();
            my_cart m1 = new my_cart();
            
            m1.ShowDialog();
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Foods AF1 = new All_Foods();
            
            AF1.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
