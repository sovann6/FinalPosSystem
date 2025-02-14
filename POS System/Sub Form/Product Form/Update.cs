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

namespace POS_System.Sub_Form.Product_Form
{
    public partial class Update : Form
    {
        private int productID;
        byte[] imageBytes;
        public Update(int productID, byte[] image,string Pname,decimal cost,int qty,decimal price,int catID)
        {
            InitializeComponent();
            this.productID = productID;
            this.imageBytes = image;
            txtCatID.Text = catID.ToString();
            txtProductName.Text = Pname;
            txtcost.Text = cost.ToString();
            txtqty.Text = qty.ToString();
            txtPrice.Text = price.ToString();
            if (image != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(image))
                {
                    Picture.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string PName = txtProductName.Text;
            decimal cost = decimal.Parse(txtcost.Text);
            int qty = int.Parse(txtqty.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int catID = int.Parse(txtCatID.Text);
            UpdateProduct( PName,cost,qty,price,catID,imageBytes);
        }

        private void UpdateProduct(string pName, decimal cost, int qty, decimal price, int catID, byte[] imageBytes)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateProduct", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_id", productID);
                    cmd.Parameters.AddWithValue("@product_name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Images", (object)imageBytes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cost", txtcost.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtqty.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@category_id", txtCatID.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Close form and return success
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> cid = new List<string>();
        private void Update_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            SqlCommand cmd = new SqlCommand("sp_Select_Category", DataConnection.DataCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                int id = Convert.ToInt32(r[0].ToString());
                string name = r[1].ToString();
                comboBoxName.Items.Add(name);
                cid.Add(id.ToString());
            }
            cmd.Dispose();
            r.Close();
            comboBoxName.SelectedIndex = 0;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxName.SelectedIndex;
            txtCatID.Text = cid[index];
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
