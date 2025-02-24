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

namespace POS_System.Sub_Form.Category_Form
{
    public partial class Update : Form
    {
       private int CatID;
       byte[] Images;
        public Update(int CatID, byte[] image,string Cat_Name,string Desc)
        {
            InitializeComponent();
            this.CatID = CatID;
            this.Images = image;
            txtName.Text = Cat_Name;
            txtDesc.Text = Desc;
            if (image != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(image))
                {
                    pictureCat.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CatName = txtName.Text;
            string Desc = txtDesc.Text;
            UpdateCate( Images, CatName, Desc);
        }
        private void UpdateCate(byte[] imagebyte, string CatName, string Desc)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateCategory", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", CatID);
                    cmd.Parameters.AddWithValue("@category_name", CatName);
                    cmd.Parameters.AddWithValue("@Description", Desc);
                    cmd.Parameters.AddWithValue("@Images", (object)imagebyte ?? DBNull.Value); // Ensure null handling

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
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
                pictureCat.Image = Image.FromFile(openFileDialog.FileName);
                Images = File.ReadAllBytes(openFileDialog.FileName); // Convert selected image to byte array
            }
        }
    }
}
