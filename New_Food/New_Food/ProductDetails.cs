using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Food
{
    public partial class ProductDetails : Form
    {
        private int quantity = 0;
        private decimal subtotal = 0;
        private decimal price = 0;
        private int productId = 0;
        public ProductDetails(int id)
        {
            InitializeComponent();
            productId = id;

            SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\user\OneDrive - Universiti Teknikal Malaysia Melaka\EVEN DRIVEN PROGRAMMING\vending_machine\New_Food\New_Food\VendingMachine.mdf;
            Integrated Security=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM [Product] WHERE product_id=@id",
                connection);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ItemName.Text = dr["productName"].ToString();
                ItemPrice.Text = Convert.ToDecimal(dr["price"]).ToString("0.00");
                price = Convert.ToDecimal(dr["price"]);
                ItemCategory.Text = dr["category"].ToString();
                ItemStock.Text = dr["stockQty"].ToString();
                ItemWeight.Text = dr["weight"].ToString();
                ItemCalories.Text = dr["calories"].ToString();
                ItemDescription.Text = dr["description"].ToString();

                //load image
                string imageName = dr["photo"].ToString();

                string imagePath = Path.Combine(
                                    Application.StartupPath,
                                    "ListItem",
                                    imageName);

                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Image not found: " + imagePath);
                }
            }

            connection.Close();


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ItemTotal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();
            if (menuForm != null)
            {
                menuForm.Show();
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quantity++;
            lblQuantity.Text = quantity.ToString();
            subtotal = quantity * price;
            ItemTotal.Text = subtotal.ToString("0.00");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                subtotal = quantity * price;
                ItemTotal.Text = "RM " + subtotal.ToString("0.00");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                CartManager.AddItem(productId, ItemName.Text, quantity, price);   // ← TAMBAH BARIS NI

                MessageBox.Show("Item added to cart!");

                Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();

                if (menuForm != null)
                {
                    menuForm.Show();
                    menuForm.BringToFront();
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select quantity first.");
            }
        }
    }
}
