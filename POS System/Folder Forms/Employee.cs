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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DatagridviewEmp.Rows.Clear();            
            string QueryEmp = "SELECT Emp_id,Image,first_name,last_name,username,password,Gender,DOB,roles,Hire_date,email,Address,PhoneNumber,Status,Salary FROM tbl_Employees;";
            SqlCommand s = new SqlCommand(QueryEmp,DataConnection.DataCon);
            SqlDataReader r= s.ExecuteReader();
            DatagridviewEmp.Rows.Clear();
            DatagridviewEmp.RowTemplate.Height = 45;
            while (r.Read()) { 
                string emp_id= r[0].ToString();
                byte[] imageData = null;
                if (r[1] != DBNull.Value)
                {
                    imageData = (byte[])r[1];
                }
                string fName= r[2].ToString();
                string lName= r[3].ToString();
                string userName= r[4].ToString();
                string password= r[5].ToString();
                string gernder= r[6].ToString();
                string Dob = r[7].ToString();
                string Role= r[8].ToString();
                string hire_date = r[9].ToString();               
                string email= r[10].ToString();
                string adds = r[11].ToString();
                string phone= r[12].ToString();
                string starus= r[13].ToString();
                string salary= r[14].ToString();
                DatagridviewEmp.Rows.Add(emp_id,imageData,fName,lName,userName,password,gernder,Dob,Role,hire_date,email,adds,phone,starus,salary);
            }
            
            r.Close();
            s.Dispose();
            string countTotalEmp = "SELECT COUNT(*) FROM tbl_Employees;";
            SqlCommand s1 = new SqlCommand(countTotalEmp, DataConnection.DataCon);
            SqlDataReader r1 = s1.ExecuteReader();
            while (r1.Read())
            {
                string total = r1[0] + "";
                TotalEmp.Text = total;
            }
            r1.Close();
            s1.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sub_Form.Add_Employee add_ =  new Sub_Form.Add_Employee();
            if (add_.ShowDialog() == DialogResult.OK) {
                Employee_Load(sender,e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DatagridviewEmp.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Please Select an Employee to delete.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string FName = DatagridviewEmp.SelectedRows[0].Cells[2].Value.ToString();
            string LName= DatagridviewEmp.SelectedRows[0].Cells[3].Value.ToString();
            string Fullname = $"{FName} {LName}";


            DialogResult = MessageBox.Show($"Are you sure you want to delete this Employee Name:{Fullname}", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            
            int emp_id = Convert.ToInt32(DatagridviewEmp.SelectedRows[0].Cells["id"].Value);
            if (DialogResult == DialogResult.Yes) { 
                DeleteEmployee(emp_id);
                Employee_Load(sender, e);
            }
        }
        private void DeleteEmployee(int emp_id) {
            try
            {
                using (SqlCommand s = new SqlCommand("sp_DeleteEmployee", DataConnection.DataCon))
                {
                    s.CommandType = CommandType.StoredProcedure;
                    s.Parameters.AddWithValue("@ID", emp_id);
                    s.ExecuteNonQuery();
                }
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DatagridviewEmp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int employeeID = Convert.ToInt32(DatagridviewEmp.SelectedRows[0].Cells["ID"].Value);
            string firstName = DatagridviewEmp.SelectedRows[0].Cells["first"].Value.ToString();
            string lastName = DatagridviewEmp.SelectedRows[0].Cells["last"].Value.ToString();
            string username = DatagridviewEmp.SelectedRows[0].Cells["username"].Value.ToString();
            string password = DatagridviewEmp.SelectedRows[0].Cells["pass"].Value.ToString();
            string gender = DatagridviewEmp.SelectedRows[0].Cells["gender"].Value.ToString();
            DateTime dob = Convert.ToDateTime(DatagridviewEmp.SelectedRows[0].Cells["dob"].Value);
            string role = DatagridviewEmp.SelectedRows[0].Cells["role"].Value.ToString();
            DateTime hireDate = Convert.ToDateTime(DatagridviewEmp.SelectedRows[0].Cells["hire"].Value);
            string email = DatagridviewEmp.SelectedRows[0].Cells["email"].Value.ToString();
            string address = DatagridviewEmp.SelectedRows[0].Cells["adr"].Value.ToString();
            string phoneNumber = DatagridviewEmp.SelectedRows[0].Cells["phone"].Value.ToString();
            string status = DatagridviewEmp.SelectedRows[0].Cells["status"].Value.ToString();
            decimal salary = Convert.ToDecimal(DatagridviewEmp.SelectedRows[0].Cells["salary"].Value);

            // Get the image data (if available)
            byte[] image = DatagridviewEmp.SelectedRows[0].Cells["image"].Value as byte[];

            // Open the UpdateEmployeeForm with the selected data
            Sub_Form.Employee_Form.UpdateEmp updateFormUpdateEmployee = new Sub_Form.Employee_Form.UpdateEmp(employeeID, firstName, lastName, username, password, gender, dob, role, hireDate, email, address, phoneNumber, status, salary, image);

            if(updateFormUpdateEmployee.ShowDialog() == DialogResult.OK)
            {
                Employee_Load(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Employee_Load(sender, e);
            }
            else
            {
                
                SqlCommand s = new SqlCommand("sp_SearchEmp", DataConnection.DataCon);
                s.CommandType = CommandType.StoredProcedure;
                s.Parameters.AddWithValue("@temp_Search", txtSearch.Text);
                SqlDataReader r = s.ExecuteReader();
                DatagridviewEmp.RowTemplate.Height = 45;
                DatagridviewEmp.Rows.Clear();
                while (r.Read())
                {
                    string emp_id = r[0].ToString();
                    byte[] imageData = null;
                    if (r[1] != DBNull.Value)
                    {
                        imageData = (byte[])r[1];
                    }
                    string fName = r[2].ToString();
                    string lName = r[3].ToString();
                    string userName = r[4].ToString();
                    string password = r[5].ToString();
                    string gernder = r[6].ToString();
                    string Dob = r[7].ToString();
                    string Role = r[8].ToString();
                    string hire_date = r[9].ToString();
                    string email = r[10].ToString();
                    string adds = r[11].ToString();
                    string phone = r[12].ToString();
                    string starus = r[13].ToString();
                    string salary = r[14].ToString();
                    DatagridviewEmp.Rows.Add(emp_id, imageData, fName, lName, userName, password, gernder, Dob, Role, hire_date, email, adds, phone, starus, salary);
                }

                r.Close();
                s.Dispose();
            }
                
        }

        //internal void UpdateEmp(int employeeID, string firstName, string lastName, string username, string password, string gender, byte[] imageBytes, DateTime dob, string roles, DateTime hireDate, string email, string address, string phoneNumber, string status, decimal salary)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
