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

namespace POS_System.Sub_Form
{
    public partial class Add_Employee : Form
    {
        public byte[] Images {  get; private set; }
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertEmployee", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboGender.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@Image", (object)Images ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DOB", DOB.Value);
                    cmd.Parameters.AddWithValue("@roles", Role.Text);
                    cmd.Parameters.AddWithValue("@Hire_date", hire_date.Value);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddr.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@Salary", decimal.Parse(txtSalary.Text));
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Close form and return success
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                Images = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
