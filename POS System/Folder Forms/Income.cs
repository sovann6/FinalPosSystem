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

namespace POS_System.Folder_Forms
{
    public partial class Income : Form
    {
        private double _amount { get; set; }
        private double TotalExpanses {  get; set; }
        private double TAX { get; set; }
        private double Dis {  get; set; }
        public Income()
        {
            InitializeComponent();
            PopulateSortComboBox();
           
        }

        private void Income_Load(object sender, EventArgs e)
        {
            LoadIncome("DESC",null,null);
            CalculateFinancials();
        }
        private void PopulateSortComboBox()
        {
            ComboO.Items.Clear();
            ComboO.Items.Add("Hight Profits");
            ComboO.Items.Add("Low Profits");

            ComboO.SelectedIndex = 0; // Set default value
            ComboO.SelectedIndexChanged += ComboO_SelectedIndexChanged;
        }
        private void LoadIncome(string orderSort, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                // Ensure the DataGridView is cleared before loading new data
                DataIcome.Rows.Clear();

                using (SqlCommand s = new SqlCommand("sp_SelectIncome", DataConnection.DataCon))
                {
                    s.CommandType = CommandType.StoredProcedure;
                    s.Parameters.AddWithValue("@SortOrder", orderSort);
                    s.Parameters.AddWithValue("@StartDate", startDate.HasValue ? startDate.Value.Date : (object)DBNull.Value);
                    s.Parameters.AddWithValue("@EndDate", endDate.HasValue ? endDate.Value.Date : (object)DBNull.Value);
                    DataIcome.RowTemplate.Height = 45;

                    using (SqlDataReader r = s.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            int incomeID = Convert.ToInt32(r[0]);
                            int saleID = Convert.ToInt32(r[1]);
                            DateTime date = r.IsDBNull(2) ? DateTime.MinValue : r.GetDateTime(2);
                            string formattedDate = date.ToString("yyyy-MM-dd");

                            decimal totalAmount = Convert.ToDecimal(r[3].ToString());
                            float tax = Convert.ToSingle(r[4].ToString());
                            float income = Convert.ToSingle(r[5].ToString());
                            string formattedIncome = income.ToString("C2");
                            string formattedTax = tax.ToString("C2");
                            string formattedTotal = totalAmount.ToString("C2");

                            DataIcome.Rows.Add(incomeID, saleID, formattedDate, formattedTotal, formattedTax, formattedIncome);
                        }
                    }
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show($"Invalid cast error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ComboO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectSortOrder = ComboO.SelectedItem.ToString() == "Low Profits" ? "ASC" : "DESC";

            DateTime? startDate = null; 
            DateTime? endDate = null;   
            LoadIncome(SelectSortOrder, startDate, endDate);

        }
        
       

        private void ComboO_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime? startDate = StartDate.Value;
            DateTime? endDate = EndDate.Value; // Use current end date for the filter
            string selectSortOrder = ComboO.SelectedItem.ToString() == "Low Profits" ? "ASC" : "DESC";

            // Reload income based on updated date range
            LoadIncome(selectSortOrder, startDate, endDate);
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime? startDate = StartDate.Value;
            DateTime? endDate = EndDate.Value; // Use current end date for the filter
            string selectSortOrder = ComboO.SelectedItem.ToString() == "Low Profits" ? "ASC" : "DESC";

            // Reload income based on updated date range
            LoadIncome(selectSortOrder, startDate, endDate);
        }
        private void CalculateFinancials()
        {
            string sql = "SELECT * FROM V_Expanse";
            string sql1 = "SELECT * FROM v_TotalsTaxAndIncome";
            using (SqlCommand cmd = new SqlCommand(sql, DataConnection.DataCon))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) { 
                        double Expanse = Convert.ToDouble(reader[0].ToString());
                        string FormateExpanse = Expanse.ToString("C2");
                        TotalsExpanse.Text = FormateExpanse;
                        TotalExpanses = Expanse;
                    }
                }
                
            }
            using (SqlCommand s = new SqlCommand(sql1, DataConnection.DataCon)) {
                using (SqlDataReader reader = s.ExecuteReader()) {
                    while (reader.Read()) { 
                        double Tax=Convert.ToDouble(reader[0].ToString());
                        TAX = Tax;
                        double Profit=Convert.ToDouble(reader[1].ToString());
                        string formateProfit = Profit.ToString("C2");
                        txtIncome.Text = formateProfit;
                        _amount = Profit;
                    }
                }
            }
            string sql2 = "SELECT Total_Discount FROM v_Discount;";
            using (SqlCommand SC = new SqlCommand(sql2, DataConnection.DataCon)) {
                using (SqlDataReader r =SC.ExecuteReader())
                {
                    while (r.Read())
                    {
                        double dis = Convert.ToDouble(r[0].ToString());
                        Dis = dis;
                    }
                }
            }
            double operatingProfit = _amount - TotalExpanses;
            TotalsOperatingPro.Text = operatingProfit > 0 ? operatingProfit.ToString("C2") : "N/A";

            //Calculate Net Profit
            double netProfit = operatingProfit - TAX;
            NetProfit.Text = netProfit.ToString("C2");

            double netExpanse = Dis - TotalExpanses;
            NetExpanse.Text = netExpanse.ToString("C2");
        }

    }
}
