using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_System.Folder_Forms
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            PopulateSortComboBox();
        }

        private void btnaddExpanse_Click(object sender, EventArgs e)
        {
            string EmpID=Login.Emp_ID;
            Sub_Form.Expanse.AddExpanse _AddExpanse=new Sub_Form.Expanse.AddExpanse(EmpID);
            if(_AddExpanse.ShowDialog()==DialogResult.OK){
                Expense_Load(sender,e);
                //DateTime startDate = StartDate.Value; // Get the start date from the control
                //DateTime endDate = EndDate.Value;     // Get the end date from the control
                //string sortOrder = ComboSort.SelectedItem.ToString() == "Low Expanse" ? "ASC" : "DESC";
                //// Call the method to load sorted expenses
                //LoadSortExpanse(sortOrder,startDate, endDate);
            }
        }
        private void PopulateSortComboBox()
        {
            ComboSort.SelectedIndex = 0; // Set default value
            ComboSort.SelectedIndexChanged += ComboSort_SelectedIndexChanged;
        }
        private void Expense_Load(object sender, EventArgs e)
        {
            ComboSort.SelectedIndex = 0;
            StartDate.Value = DateTime.Now.AddDays(-30); // Default to last 30 days
            EndDate.Value = DateTime.Now; // Default to today
            LoadSortExpanse("DESC", StartDate.Value, EndDate.Value); // Load with default dates
        }
        private void LoadSortExpanse(string sortOrder, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                // Ensure the DataGridView is cleared before loading new data
                DataExpanse.Rows.Clear();

                using (SqlCommand s = new SqlCommand("sp_SortExpensesByDate", DataConnection.DataCon))
                {
                    s.CommandType = CommandType.StoredProcedure;
                    s.Parameters.AddWithValue("@SortOrder", sortOrder);
                    s.Parameters.AddWithValue("@StartDate", startDate.HasValue ? startDate.Value.Date : (object)DBNull.Value);
                    s.Parameters.AddWithValue("@EndDate", endDate.HasValue ? endDate.Value.Date : (object)DBNull.Value);
                    DataExpanse.RowTemplate.Height = 45;
                    using (SqlDataReader r = s.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            int expanseID = Convert.ToInt32(r[0]);
                            string description = r[1].ToString();
                            decimal amount = Convert.ToDecimal(r[2].ToString());
                            DateTime date = r.IsDBNull(3) ? DateTime.MinValue : r.GetDateTime(3);
                            string formattedDate = date.ToString("yyyy-MM-dd");
                            int empID = Convert.ToInt32(r[4]);

                            DataExpanse.Rows.Add(expanseID, description, amount.ToString("C2"), formattedDate, empID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime? startDate = StartDate.Value;
            DateTime? endDate = EndDate.Value;
            string sortOrder = ComboSort.SelectedItem.ToString() == "Low Expanse" ? "ASC" : "DESC";

            LoadSortExpanse(sortOrder, startDate, endDate);
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime? startDate = StartDate.Value;
            DateTime? endDate = EndDate.Value;
            string sortOrder = ComboSort.SelectedItem.ToString() == "Low Expanse" ? "ASC" : "DESC";

            LoadSortExpanse(sortOrder, startDate, endDate);
        }

        private void ComboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectSortOrder = ComboSort.SelectedItem.ToString() == "Low Expanse" ? "ASC" : "DESC";

            DateTime? startDate = null;
            DateTime? endDate = null;
            LoadSortExpanse(SelectSortOrder, startDate, endDate);



        }

        
    }
}
