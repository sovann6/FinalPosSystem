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
    public partial class Insert : Form
    {
        public byte[] Images { get; private set; }

        public Insert()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertProduct", DataConnection.DataCon)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_name",txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Images",(object)Images?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cost",txtcost.Text);
                    cmd.Parameters.AddWithValue("@quantity",txtqty.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@category_id",txtCatID.Text);
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
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
        private List<string> cid = new List<string>();
        private void Insert_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            string Query = "SELECT * FROM tbl_Categories";
            SqlCommand cmd=new SqlCommand(Query,DataConnection.DataCon);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read()) { 
                string CatID= r[0].ToString();
                string CatName = r[1].ToString();
                comboCatName.Items.Add(CatName);
                cid.Add(CatID);
            }
            comboCatName.SelectedIndex = 0;
            r.Close();
            cmd.Dispose();
        }

        private void comboCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index= comboCatName.SelectedIndex;
            txtCatID.Text = cid[index];
        }
    }
}
