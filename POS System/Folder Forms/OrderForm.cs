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
        private const decimal TaxRate = 0.10m;
        public decimal TotalAmount { get; set; }
        public decimal Tax { get; set; }
        List<OrderDetails> orderDetails = new List<OrderDetails>();
        public OrderForm()
        {
            InitializeComponent();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            CategoriesLoaad();
            LoadProduct();
            
        }
        private void LoadProduct(string catecory = "All")
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing items

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetProductsByCategory", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_name", catecory);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Orders PC = new Orders
                            {
                                Stock= Convert.ToInt32(dr["stock_quantity"]),
                                Product_ID = Convert.ToInt32(dr["product_id"]),
                                Product_Name = dr["product_name"].ToString(),
                                Product_Price = dr["price"] != DBNull.Value ? Convert.ToDecimal(dr["price"]).ToString("C2") : "N/A" // Format as currency
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
        private void CategoriesLoaad()
        {
            string query = "SELECT DISTINCT category_name FROM tbl_Categories;";
            try
            {
                SqlCommand s = new SqlCommand(query, DataConnection.DataCon);
                SqlDataReader dr = s.ExecuteReader();
                ComCat.Items.Clear();
                ComCat.Items.Add("All");
                while (dr.Read())
                {
                    ComCat.Items.Add(dr["category_name"].ToString());
                }
                dr.Close();
                s.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            ComCat.SelectedIndex = 0;
        }

       
        private void Product_Card_AddItem(object sender, EventArgs e)
        {
            if (!(sender is Orders Select_Product) || Select_Product == null)
            {
                MessageBox.Show("Invalid Product selection.");
                return;
            }
            int selcteProductID = Select_Product.Product_ID;
            int stock = Select_Product.Stock;
            bool PExist = false;
            foreach (DataGridViewRow row in Desplay.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == Select_Product.Product_Name)
                {
                    
                    int current = Convert.ToInt32(row.Cells[2].Value);
                    if (current +1> stock)
                    {
                        MessageBox.Show("Not enough stock for product: " + Select_Product.Product_Name,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    current++;

                    row.Cells[2].Value = current;

                    string priceText = Select_Product.Product_Price.Replace("$", "").Replace("€", "").Trim();
                    if (decimal.TryParse(priceText, out decimal unitPrice))
                    {
                        row.Cells[4].Value = unitPrice * current;
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
                if (!decimal.TryParse(priceText, out unitPrice))
                {
                    MessageBox.Show("Invalid product price format.");
                }

                // Add a new row.
                int rowIndex = Desplay.Rows.Add();
                DataGridViewRow newRow = Desplay.Rows[rowIndex];
                // Set the "No." column value as the row index + 1.
                newRow.Cells[0].Value = rowIndex + 1;
                newRow.Cells[1].Value = Select_Product.Product_Name;
                newRow.Cells[2].Value = 1;
                newRow.Cells[3].Value = Select_Product.Product_Price;
                newRow.Cells[4].Value = unitPrice;
                newRow.Cells[6].Value = Select_Product.Product_ID;
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
            Tax = (TotalAmounts * TaxRate);
            taxs.Text = Tax.ToString("C2");
            TotalAmount = TotalAmounts + Tax;
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


        private void Desplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Desplay.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Desplay.Rows.RemoveAt(e.RowIndex);
                    RememberRows();
                    SumAmount();
                    CountItems();
                }
            }
        }
        private void RememberRows()
        {
            for (int i = 0; Desplay.Rows.Count > i; i++)
            {
                Desplay.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void ComCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectCategory = ComCat.SelectedItem.ToString();
            LoadProduct(SelectCategory);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string RoleName = Login.RoleName;
            string EmpID = Login.Emp_ID;
            if (Desplay.Rows.Count == 0)
            {
                MessageBox.Show("No items to pay for.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Payments p = new Payments(EmpID,RoleName);
            p.GetProductDetails(Desplay);
            p.ShowDialog();
            if (p.DialogResult == DialogResult.OK)
            {
                int OrderID = InsertOrder(p.DisValue, p.TotalPay, TotalAmount, Tax, EmpID);
                if (OrderID > 0)
                {
                    InsertOrderDetail(OrderID);
                    UpdateStock(OrderID);
                }
                Desplay.Rows.Clear();
                CountItems();
                SumAmount();
            }

        }
        private void InsertOrderDetail(int OrderID)
        {
            try
            {

                foreach (DataGridViewRow item in Desplay.Rows)
                {
                    if (item.Cells[6] != null)
                    {
                        int productID = Convert.ToInt32(item.Cells[6].Value);
                        int quantity = Convert.ToInt32(item.Cells[2].Value);


                        using (SqlCommand cmd = new SqlCommand("sp_InsertSaleDetail", DataConnection.DataCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@SaleID", OrderID);  // Use OrderID instead of SaleID
                            cmd.Parameters.AddWithValue("@ProductID", productID);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Order Details Inserted Successfully", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Order Details Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private int InsertOrder(decimal discountAmount, decimal totalPay, decimal price, decimal discount, string empID)
        {
            string date = DateTime.Now.ToString("dd-MMM-yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            int orderId = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertSales", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderDate", date);
                    cmd.Parameters.AddWithValue("@OrderTime", time);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@DiscountValue", discountAmount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", discount);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPay);
                    cmd.Parameters.AddWithValue("@EmployeeID", empID);

                    // Execute the command and capture the orderId
                    object result = cmd.ExecuteScalar();  // ExecuteScalar will return the result of SCOPE_IDENTITY()
                    if (result != null && int.TryParse(result.ToString(), out orderId))
                    {
                        return orderId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orderId;
        }
        private void UpdateStock(int orderId)
        {
            try
            {
                foreach (DataGridViewRow row in Desplay.Rows)
                {
                    if (row.Cells[6].Value != null) // Check if the product ID exists
                    {
                        int productId = Convert.ToInt32(row.Cells[6].Value);
                        int quantity = Convert.ToInt32(row.Cells[2].Value);

                        using (SqlCommand cmd = new SqlCommand("sp_UpdateStock", DataConnection.DataCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@SaleID", orderId);  
                            cmd.ExecuteNonQuery();  
                        }
                    }
                }

                MessageBox.Show("Stock updated successfully after order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Stock Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
