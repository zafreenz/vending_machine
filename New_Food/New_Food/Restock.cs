using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_Food
{
    public partial class Restock : Form
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                            AttachDbFilename=|DataDirectory|\VendingMachine.mdf;
                            Integrated Security=True";

        public Restock()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Snack")
            {
                comboBox2.Items.Add("Cheetos Crunchy");
                comboBox2.Items.Add("Dorito Nancho Cheese");
                comboBox2.Items.Add("Mi-Mi Prawn Sticks");
                comboBox2.Items.Add("Super Ring Cheese");
                comboBox2.Items.Add("Tam Tam Crab Snack");
                comboBox2.Items.Add("Rota Prawn Crackers");
                comboBox2.Items.Add("Bika Chicken Crackers");
                comboBox2.Items.Add("Twisties BBQ Curry");
                comboBox2.Items.Add("Popo Fish Muruku");
                comboBox2.Items.Add("Durian Popcorn");
                comboBox2.Items.Add("Lay's Classic Salted");
                comboBox2.Items.Add("Mamee Monster Spicy");
            }
            else if (comboBox1.Text == "Bread")
            {
                comboBox2.Items.Add("Gardenia QuickBites Chocolate");
                comboBox2.Items.Add("Gardenia QuickBites Durian");
                comboBox2.Items.Add("Gardenia Puazz Sambal Bilis");
                comboBox2.Items.Add("7 Days Croissant Chocolate");
                comboBox2.Items.Add("7 Days Croissant Vanilla");
                comboBox2.Items.Add("Gardenia QuickBites Red Bean");
                comboBox2.Items.Add("Gardenia QuickBites Corn");
            }
            else if (comboBox1.Text == "Nuts")
            {
                comboBox2.Items.Add("Nature's Wonders Baked Cashews");
                comboBox2.Items.Add("Tong Garden Cocktail Nuts");
                comboBox2.Items.Add("Tong Garden Salted Cashews");
                comboBox2.Items.Add("Tong Garden Premium Cocktail Mix");
                comboBox2.Items.Add("Tong Garden All Natural Mix");
                comboBox2.Items.Add("Cap Tangan Groundnuts");
                comboBox2.Items.Add("ChaCheer Sunflower Seeds");
            }
            else if (comboBox1.Text == "Biscuit")
            {
                comboBox2.Items.Add("Nutella B-ready");
                comboBox2.Items.Add("Lexus Chocolate Cream");
                comboBox2.Items.Add("Lotus Biscoff Biscuit");
                comboBox2.Items.Add("Tiger Biscuit Original");
                comboBox2.Items.Add("Loacker Quadratini Chocolate");
                comboBox2.Items.Add("Oreo Original Sandwich");
                comboBox2.Items.Add("Pocky Chocolate Sticks");
                comboBox2.Items.Add("Milo Biscuit Pack");
                comboBox2.Items.Add("Chips More Original Mini");
            }
            else if (comboBox1.Text == "Candies")
            {
                comboBox2.Items.Add("Chupa Chups Sour Bites");
                comboBox2.Items.Add("Haribo Goldbears");
                comboBox2.Items.Add("Fruit Plus Chewy Candy");
                comboBox2.Items.Add("M&M's Peanut Pouch");
                comboBox2.Items.Add("M&M's Milk Chocolate Pouch");
                comboBox2.Items.Add("Tic Tac Strawberry Mint");
                comboBox2.Items.Add("Mentos Mint Roll");
                comboBox2.Items.Add("Skittles Fruits Box");
                comboBox2.Items.Add("Skittles Sour Pack");
            }
            else if (comboBox1.Text == "Carbonated")
            {
                comboBox2.Items.Add("Pepsi Regular Can");
                comboBox2.Items.Add("Coca-Cola Classic");
                comboBox2.Items.Add("Fanta Orange");
                comboBox2.Items.Add("Sprite Lemon-Lime");
                comboBox2.Items.Add("7Up Lemon Lime");
                comboBox2.Items.Add("Mountain Dew");
                comboBox2.Items.Add("Monster Energy Original");
                comboBox2.Items.Add("Red Bull Energy Drink");
                comboBox2.Items.Add("Fanta Strawberry");
                comboBox2.Items.Add("100 Plus Isotonic");
                comboBox2.Items.Add("Monster Energy Ultra White");
                comboBox2.Items.Add("Coca-Cola Zero Sugar");
            }
            else if (comboBox1.Text == "Juices")
            {
                comboBox2.Items.Add("Marigold 100% Orange Juice");
                comboBox2.Items.Add("Marigold 100% Apple Juice");
                comboBox2.Items.Add("Ceres 100% Apple Pouch");
                comboBox2.Items.Add("Marigold Mixed Berries");
                comboBox2.Items.Add("Marigold Tropical Fruits");
                comboBox2.Items.Add("Ceres Exotic Secrets Fruit");
                comboBox2.Items.Add("Ceres 100% Kiwi Blend");
            }
            else if (comboBox1.Text == "Milk")
            {
                comboBox2.Items.Add("Goodday Full Cream Milk");
                comboBox2.Items.Add("Goodday Low Fat Milk");
                comboBox2.Items.Add("Dutch Lady Strawberry Milk");
                comboBox2.Items.Add("Milo Active-Go UHT");
                comboBox2.Items.Add("Dutch Lady Juicy Milk Orange");
                comboBox2.Items.Add("Dutch Lady Chocolate Milk");
                comboBox2.Items.Add("Oatside Barista Oat Milk Mini");
                comboBox2.Items.Add("Oatside Chocolate Oat Milk Mini");
                comboBox2.Items.Add("Oatside Coffee Pocket Pack");
            }
            else if (comboBox1.Text == "Mineral Water")
            {
                comboBox2.Items.Add("Spritzer Natural Mineral Water");
                comboBox2.Items.Add("Evian Natural Spring Water");
                comboBox2.Items.Add("Desa Mineral Water");
                comboBox2.Items.Add("Dasani Sparkling Water");
            }
            else if (comboBox1.Text == "Yogurt")
            {
                comboBox2.Items.Add("Nestle Bliss Tropical Fruit");
                comboBox2.Items.Add("Nestle Bliss Strawberry");
                comboBox2.Items.Add("Nestle Bliss Mango");
                comboBox2.Items.Add("Nestle Bliss Peach");
                comboBox2.Items.Add("Calpis Mango Cultured");
                comboBox2.Items.Add("Calpis Grape Cultured");
                comboBox2.Items.Add("Calpis Original");
                comboBox2.Items.Add("Anlene Yogurt Mixed Berries");
            }
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
                return;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query =
                    "SELECT StockQty FROM Product WHERE ProductName = @name";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", comboBox2.Text);

                con.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentStock = Convert.ToInt32(textBox1.Text);
            int addQuantity = (int)numericUpDown1.Value;

            int totalStock = currentStock + addQuantity;

            textBox3.Text = totalStock.ToString();

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename=|DataDirectory|\VendingMachine.mdf;
                        Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE Product SET stockQty = @stock WHERE productName = @name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@stock", totalStock);
                cmd.Parameters.AddWithValue("@name", comboBox2.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Stock updated!");
        }

        private void Restock_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Snack");
            comboBox1.Items.Add("Bread");
            comboBox1.Items.Add("Nuts");
            comboBox1.Items.Add("Biscuit");
            comboBox1.Items.Add("Candies");

            comboBox1.Items.Add("Carbonated");
            comboBox1.Items.Add("Juices");
            comboBox1.Items.Add("Milk");
            comboBox1.Items.Add("Mineral Water");
            comboBox1.Items.Add("Yogurt");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dashboard_admin da = new dashboard_admin();
            da.Show();
            this.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            settings_admin sa = new settings_admin();
            sa.Show();
            this.Hide();
        }
    }
}