using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Folder_Forms
{
    public partial class Dashoard : Form
    {
        private decimal IncomeToday { get; set; }
        private decimal ExpenseToday { get; set; }
        public Dashoard(string role,string fullname, byte[] img)
        {
            InitializeComponent();
            label_Name.Text =fullname;
            labelPosition.Text=role;
            if (img != null) {
                using (MemoryStream ms = new MemoryStream(img)) {
                    Image image= Image.FromStream(ms);
                    guna2CirclePictureBox1.Image= image;
                }
            }
            
        }
        public (decimal totalIncome, decimal totalExpense) GetTodayIncomeExpenseTotals()
        {
                decimal totalIncome = 0, totalExpense = 0;
            
                try
                {
                    string query = @"
                    SELECT 
                        (SELECT ISNULL(SUM(totals_price), 0) FROM tbl_Income WHERE CAST(Income_date AS DATE) = CAST(GETDATE() AS DATE)) AS TotalIncome,
                        (SELECT ISNULL(SUM(amount), 0) FROM tbl_Expanse WHERE CAST(expanse_date AS DATE) = CAST(GETDATE() AS DATE)) AS TotalExpense";

                    using (SqlCommand cmd = new SqlCommand(query, DataConnection.DataCon))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalIncome = reader.GetDecimal(0);
                                totalExpense = reader.GetDecimal(1);
                                string totalIncomeString = totalIncome.ToString("C");
                                string totalExpenseString = totalExpense.ToString("C");
                                txtIncome.Text = totalIncomeString;
                                lbtExpanse.Text = totalExpenseString;
                                decimal totalProfit = totalIncome - totalExpense;
                                string totalProfitString = totalProfit.ToString("C");
                                lbtNetProfits.Text = totalProfitString;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            
            return (totalIncome, totalExpense);
        }
        private void Dashoard_Load(object sender, EventArgs e)
        {
            GetTodayIncomeExpenseTotals();
            int currentHour = DateTime.Now.Hour;  
            Time.Text =  GetTimeOfDay(currentHour) + "!";
            string countTotalEmp = "SELECT COUNT(*) FROM tbl_Employees;";
            SqlCommand s = new SqlCommand(countTotalEmp, DataConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            while (r.Read())
            {
                string total = r[0] + "";
                label_totalemp.Text = total;
            }
            r.Close();
            s.Dispose();
            string RoleAdmin = "SELECT COUNT(*) FROM tbl_Employees\r\n WHERE roles= 'admin';";
            SqlCommand s1 = new SqlCommand(RoleAdmin, DataConnection.DataCon);
            SqlDataReader r1 = s1.ExecuteReader();
            while (r1.Read())
            {
                string total = r1[0] + "";
                label_Admin.Text= total;
            }
            r1.Close();
            s1.Dispose();
            string RoleSale = " SELECT COUNT(*) FROM tbl_Employees\r\n WHERE roles= 'sale';";
            SqlCommand s2 = new SqlCommand(RoleSale, DataConnection.DataCon);
            SqlDataReader r2 = s2.ExecuteReader();
            while (r2.Read())
            {
                string total = r2[0] + "";
                label_Sale.Text = total;
            }
            r2.Close();
            s2.Dispose();
            SqlCommand s3 = new SqlCommand("sp_CountP",DataConnection.DataCon);
            s3.CommandType = CommandType.StoredProcedure;
            SqlDataReader r3 = s3.ExecuteReader();
            while (r3.Read())
            {
                string total = r3[0] + "";
                lbPro.Text = total;
            }
            r3.Close();
            s3.Dispose();
            SqlCommand s4 = new SqlCommand("sp_CountCat", DataConnection.DataCon);
            s4.CommandType = CommandType.StoredProcedure;
            SqlDataReader r4 = s4.ExecuteReader();
            while (r4.Read())
            {
                string total = r4[0] + "";
                lbCat.Text = total;
            }
            r4.Close();
            s4.Dispose();
            SqlCommand s5 = new SqlCommand("sp_CountOrder",DataConnection.DataCon);
            s5.CommandType = CommandType.StoredProcedure;
            SqlDataReader r5=s5.ExecuteReader();
            while (r5.Read()) {
                int OrderCount = int.Parse(r5[0].ToString());
                lbOrders.Text = OrderCount.ToString();
            }
            r5.Close();
            s5.Dispose();
        }

        private string GetTimeOfDay(int hour)
        {
            if (hour >= 5 && hour < 12)
                return "Good Morning";
            else if (hour >= 12 && hour < 17)
                return "Good Afternoon";
            else if (hour >= 17 && hour < 21)
                return "Good Evening";
            else
                return "Good Night";
        }
        private static void QueryCount()
        {
            
               
        }
    }
}
