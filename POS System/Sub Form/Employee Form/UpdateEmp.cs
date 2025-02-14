using POS_System.Folder_Forms;
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

namespace POS_System.Sub_Form.Employee_Form
{
    public partial class UpdateEmp : Form
    {

        private int employeeID;
        private byte[] imageBytes;
        public UpdateEmp(int id, string firstName, string lastName, string username, string password, string gender, DateTime dob, string roles, DateTime hireDate, string email, string address, string phoneNumber, string status, decimal salary, byte[] image)
        {
            InitializeComponent();
            // Initialize data
            this.employeeID = id;
            this.imageBytes = image;

            // Populate controls with existing data
            txtFirstName.Text = firstName;
            txtLastname.Text = lastName;
            txtUsername.Text = username;
            txtPass.Text = password;
            comboGender.SelectedItem = gender; // ComboBox for gender
            DOB.Value = dob;
            txtRole.Text = roles;
            hire_date.Value = hireDate;
            txtEmail.Text = email;
            txtAddr.Text = address;
            txtPoneNumber.Text = phoneNumber;
            txtstatus.Text = status;
            txtSalary.Text = salary.ToString();

            // Set the image (if exists)
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    Picture.Image = Image.FromStream(ms); // PictureBox for the image
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastname.Text;
            string username = txtUsername.Text;
            string password = txtPass.Text;
            string gender = comboGender.SelectedItem.ToString();
            DateTime dob = DOB.Value;
            string roles = txtRole.Text;
            DateTime hireDate = hire_date.Value;
            string email = txtEmail.Text;
            string address = txtAddr.Text;
            string phoneNumber = txtPoneNumber.Text;
            string status = txtstatus.Text;
            decimal salary = Convert.ToDecimal(txtSalary.Text);

            // Update the employee in the database
            UpdateEmployeeInDatabase(employeeID, firstName, lastName, username, password, gender, imageBytes, dob, roles, hireDate, email, address, phoneNumber, status, salary);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = Image.FromFile(openFileDialog.FileName);
                imageBytes = File.ReadAllBytes(openFileDialog.FileName); // Convert selected image to byte array
            }
        }
        private void UpdateEmployeeInDatabase(int employeeID, string firstName, string lastName, string username, string password, string gender, byte[] image, DateTime dob, string roles, DateTime hireDate, string email, string address, string phoneNumber, string status, decimal salary)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateEmployee", DataConnection.DataCon))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@Emp_id", employeeID);
                    command.Parameters.AddWithValue("@first_name", firstName);
                    command.Parameters.AddWithValue("@last_name", lastName);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Image", image ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@roles", roles);
                    command.Parameters.AddWithValue("@Hire_date", hireDate);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Salary", salary);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void UpdateEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
