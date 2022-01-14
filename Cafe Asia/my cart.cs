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
    public partial class my_cart : MetroFramework.Forms.MetroForm
    {
     //   Class1 c1 = new Class1();
        database db = new database();

        int total=0;

        public my_cart()
        {
            InitializeComponent();
            tot();
        }

        public void tot()
        {
            string q = "select Item_Name,Unit_price,quantity,price from food";
            guna2DataGridView1.DataSource = db.getData(q);


            for (int i = 0; i < guna2DataGridView1.Rows.Count; ++i)
            {
                total += Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[3].Value);
            }

            txt_grandtotal.Text = "Rs." + total.ToString();

        }






        private void guna2Button2_Click(object sender, EventArgs e)
        {
            payment p1 = new payment();
            this.Hide();
            p1.ShowDialog();
        }

        private void btn_continu_shopping_Click(object sender, EventArgs e)
        {
            this.Close();
            All_Foods a1 = new All_Foods();
            a1.ShowDialog();
        }

        private void my_cart_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      public int amount;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            txt_grandtotal.Text = "Rs." + total;

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            All_Foods a1 = new All_Foods();
            this.Hide();
            a1.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
        }
    }
}
