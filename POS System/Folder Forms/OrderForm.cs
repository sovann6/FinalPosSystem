using POS_System.Sub_Form.Orders_Form;
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

namespace POS_System.Folder_Forms
{
    public partial class OrderForm : Form
    {
        public decimal TotalAmount { get; set; }
        public double Tax { get; set; }
        public OrderForm()
        {
            InitializeComponent();
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void LoadProduct()
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing items
            string query = "SELECT product_name,price,Images FROM tbl_Products;";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, DataConnection.DataCon))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Orders PC = new Orders
                            {
                                Product_Name = dr["product_name"].ToString(),
                                Product_Price = Convert.ToDecimal(dr["price"]).ToString("C2") // Format as currency
                            };

                            if (dr["Images"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])dr["Images"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    PC.Product_Image = Image.FromStream(ms);
                                }
                            }

                            PC.AddItem += Product_Card_AddItem; // Subscribe to event
                            flowLayoutPanel1.Controls.Add(PC);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void Product_Card_Load(object sender, EventArgs e)
        {

        }
        private void Product_Card_AddItem(object sender, EventArgs e)
        {
            Orders Select_Product = sender as Orders;
            if (Select_Product == null)
            {
                MessageBox.Show($"Product Add:{Select_Product.Product_Name}");
                return;
            }
            bool PExist = false;
            foreach (DataGridViewRow row in Desplay.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == Select_Product.Product_Name){
                    int current = Convert.ToInt32(row.Cells[2].Value);
                    current++;
                    row.Cells[2].Value = current;
                    string priceText = Select_Product.Product_Price.Replace("$", "").Replace("€", "").Trim();
                    if(decimal.TryParse(priceText,out decimal uniprice)){
                        row.Cells[4].Value=uniprice *current;
                    }
                    PExist = true;
                    break;
                }
                
            }
            if (!PExist)
            {
                Desplay.RowTemplate.Height = 80;
                // Parse the unit price.
                string priceText = Select_Product.Product_Price.Replace("$", "").Replace("€", "").Trim();
                decimal unitPrice = 0;
                decimal.TryParse(priceText, out unitPrice);

                // Add a new row.
                int rowIndex = Desplay.Rows.Add();
                DataGridViewRow newRow = Desplay.Rows[rowIndex];
                // Set the "No." column value as the row index + 1.
                newRow.Cells[0].Value = rowIndex + 1;
                newRow.Cells[1].Value = Select_Product.Product_Name;
                newRow.Cells[2].Value = 1;
                newRow.Cells[3].Value = Select_Product.Product_Price;                
                newRow.Cells[4].Value = unitPrice;
            }
            SumAmount();
            CountItems();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void SumAmount()
        {
            decimal TotalAmounts = 0;
            foreach (DataGridViewRow row in Desplay.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal rowTotal))
                    {
                        TotalAmounts += rowTotal;
                    }
                }
            }
            totalssub.Text = TotalAmounts.ToString("C2");
            decimal tax=(TotalAmounts * 10)/100;
            taxs.Text = tax.ToString("C2");
            TotalAmount = TotalAmounts += tax;
            Amounts.Text = TotalAmount.ToString("C2");
        }
        private void CountItems()
        {
            int count = 0;
            foreach (DataGridViewRow row in Desplay.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    count += Convert.ToInt32(row.Cells[2].Value);
                }
            }
            lbTPO.Text = count.ToString();
        }

    }
}
