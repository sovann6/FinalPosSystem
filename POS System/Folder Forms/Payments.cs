using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuDataGridView.Transitions;

namespace POS_System.Folder_Forms
{
    public partial class Payments : Form
    {
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal DisValue { get; set; }
        public decimal TotalPay { get; set; }
        public decimal CashReceived { get; set; }
        public decimal CashReturn { get; set; }
        public decimal TotalAmount { get; set; }
        private decimal TaxRate = 0.10m;  // 10% tax rate
        public int Emp_ID { get; set; }
        public Payments(string empID, string role)
        {
            InitializeComponent();
            lbRole.Text = role;
            lbempID.Text = empID;
            Emp_ID = int.Parse(empID);
        }
        private void Payments_Load(object sender, EventArgs e)
        {
            DisAmount.Text = DisValue.ToString("C2");
            lbSubtotals.Text = TotalAmount.ToString("C2");
            timer1.Start();
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            if (ComboDis.Items.Count > 0)
            {
                ComboDis.SelectedIndex = 0;
            }
            btnPayment.Enabled = false;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public decimal GetTotalAmount()
        {
            return TotalAmount;
        }

        public void GetProductDetails(DataGridView SourceGrid)
        {
            TotalAmount = 0m; // Reset total

            foreach (DataGridViewRow row in SourceGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (!int.TryParse(row.Cells[0].Value?.ToString(), out int productID) || productID <= 0)
                    {
                        MessageBox.Show($"Invalid Product ID for product: {row.Cells[1].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // 1. Parse Quantity
                    if (!int.TryParse(row.Cells[2].Value?.ToString(), out int quantity) || quantity <= 0)
                    {
                        MessageBox.Show($"Invalid quantity for product: {row.Cells[1].Value}");
                        return;
                    }

                    // 2. Parse Price (Handling Currency Symbols)
                    string priceString = row.Cells[3].Value?.ToString();
                    if (!decimal.TryParse(
                        priceString,
                        NumberStyles.Currency,
                        CultureInfo.CurrentCulture, // Use your app's culture
                        out decimal price
                    ))
                    {
                        MessageBox.Show($"Invalid price format for product: {row.Cells[1].Value}");
                        return;
                    }

                    Price = price;
                    decimal rowTotal = quantity * price;
                    TotalAmount += rowTotal;
                    OrderDetails order = new OrderDetails(quantity, productID);
                    // 4. Add to DataGridView (store raw numeric value)
                    Data.Rows.Add(
                        quantity,
                        row.Cells[1].Value?.ToString(),
                        price.ToString("C2"), // Store numeric value
                        rowTotal.ToString("C2") // Format for display only
                    );
                }
            }

            lbSubtotals.Text = TotalAmount.ToString("C2");
            FunctionCalculate();
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {


            DialogResult = DialogResult.OK;
            if (DialogResult == DialogResult.OK)
            {
               
                this.Close();
            }
        }
       
        private decimal GetDiscount()
        {
            return Discount;
        }

        private void ComboDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDis.SelectedItem == null) return;

            // Assuming ComboDis is your ComboBox
            if (ComboDis.SelectedItem != null)
            {
                string dis = ComboDis.SelectedItem.ToString(); // Get selected item from ComboBox
                bool isPercentage = dis.EndsWith("%"); // Check if the value is a percentage
                string numberPart = isPercentage ? dis.TrimEnd('%') : dis; // Remove '%' if it's a percentage

                if (decimal.TryParse(numberPart, out decimal parsedValue))
                {
                    // Assign the parsed value to the Discount property
                    Discount = parsedValue;

                    if (isPercentage)
                    {
                        DisValue = TotalAmount * (parsedValue / 100); // Percentage discount
                    }
                    else
                    {
                        DisValue = parsedValue; // Fixed discount
                    }

                    DisAmount.Text = DisValue.ToString("C2");
                    FunctionCalculate(); // Trigger recalculation
                }
                else
                {
                    MessageBox.Show("Invalid discount format.");
                    DisValue = 0;
                }
            }
            else
            {
                MessageBox.Show("Please select a discount option.");
            }


        }
        private void FunctionCalculate()
        {
            decimal Tax = (TotalAmount * TaxRate);
            LbTax.Text = Tax.ToString("C2");
            decimal Total = TotalAmount + Tax - DisValue;
            lbTotalsPay.Text = Total.ToString("C2");
            TotalPay = Total;
        }


        private void txtCashReceived_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string input = txtCashReceived.Text.Trim();

                // Handle empty input
                if (string.IsNullOrEmpty(input))
                {
                    lbReturn.Text = "$0.00";
                    btnPayment.Enabled = false;
                    return;
                }

                // Parse with currency format support
                if (decimal.TryParse(input,
                    NumberStyles.Currency,
                    CultureInfo.CurrentCulture,
                    out decimal cashReceived))
                {
                    CashReceived = cashReceived;

                    if (CashReceived >= TotalPay)
                    {
                        decimal change = CashReceived - TotalPay;
                        lbReturn.Text = change.ToString("C2");
                        btnPayment.Enabled = true;
                    }
                    else
                    {
                        lbReturn.Text = "$0.00";
                        btnPayment.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid currency amount.",
                                  "Invalid Input",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    txtCashReceived.Text = string.Empty;
                    lbReturn.Text = "$0.00";
                    btnPayment.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}

