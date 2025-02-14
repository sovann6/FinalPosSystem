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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand s = new SqlCommand("sp_SelectAllProducts", DataConnection.DataCon);
                s.CommandType = CommandType.StoredProcedure;
                SqlDataReader r = s.ExecuteReader();
                DatagridviewPro.RowTemplate.Height = 80;
                DatagridviewPro.Rows.Clear();
                while (r.Read())
                {
                    int id = Convert.ToInt32(r[0].ToString());
                    byte[] imageData = null;
                    if (r[1] != DBNull.Value)
                    {
                        imageData = (byte[])r[1];
                    }
                    string ProName = r[2].ToString();
                    decimal cost = decimal.Parse(r[3].ToString());
                    int qty = Convert.ToInt32(r[4].ToString());
                    decimal Price = decimal.Parse(r[5].ToString());
                    int cat = Convert.ToInt32(r[6].ToString());
                    DatagridviewPro.Rows.Add(id, imageData, ProName, cost, qty, Price, cat);
                }
                r.Close();
                s.Dispose();
            }
            catch(Exception ex) { MessageBox.Show($"Error:{ex}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                Products_Load(sender,e);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_SearchProducts", DataConnection.DataCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@search_term", txtSearch.Text);
                    DatagridviewPro.Rows.Clear();
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        int id = Convert.ToInt32(r[0].ToString());
                        byte[] imageData = null;
                        if (r[1] != DBNull.Value)
                        {
                            imageData = (byte[])r[1];
                        }
                        string ProName = r[2].ToString();
                        decimal cost = decimal.Parse(r[3].ToString());
                        int qty = Convert.ToInt32(r[4].ToString());
                        decimal Price = decimal.Parse(r[5].ToString());
                        int cat = Convert.ToInt32(r[6].ToString());
                        DatagridviewPro.Rows.Add(id, imageData, ProName, cost, qty, Price, cat);
                    }
                    r.Close();
                    cmd.Dispose();

                }
                catch (Exception ex) { MessageBox.Show($"Error:{ex}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sub_Form.Product_Form.Insert _add = new Sub_Form.Product_Form.Insert();
            if (_add.ShowDialog()==DialogResult.OK)
            {
                Products_Load(sender,e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(DatagridviewPro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pro_id = Convert.ToInt32(DatagridviewPro.SelectedRows[0].Cells[0].Value);
            byte[] img = (byte[])DatagridviewPro.SelectedRows[0].Cells[1].Value;
            string pro_name = DatagridviewPro.SelectedRows[0].Cells[2].Value.ToString();
            decimal cost = decimal.Parse(DatagridviewPro.SelectedRows[0].Cells[3].Value.ToString());
            int qty = Convert.ToInt32(DatagridviewPro.SelectedRows[0].Cells[4].Value);
            decimal price = decimal.Parse(DatagridviewPro.SelectedRows[0].Cells[5].Value.ToString());
            int cat = Convert.ToInt32(DatagridviewPro.SelectedRows[0].Cells[6].Value);
            Sub_Form.Product_Form.Update _update = new Sub_Form.Product_Form.Update(pro_id, img, pro_name, cost, qty, price, cat);
            if (_update.ShowDialog() == DialogResult.OK)
            {
                Products_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DatagridviewPro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string PName= DatagridviewPro.SelectedRows[0].Cells[2].Value.ToString();
            int pro_id = Convert.ToInt32(DatagridviewPro.SelectedRows[0].Cells[0].Value);
            DialogResult = MessageBox.Show($"Are you sure you want to delete this Product Name:{PName}", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                DeleteProduct(pro_id);
                Products_Load(sender, e);
            }
        }
        private void DeleteProduct(int pro_id)
        {
            try
            {
                using (SqlCommand s = new SqlCommand("sp_DeleteProduct", DataConnection.DataCon))
                {
                    s.CommandType = CommandType.StoredProcedure;
                    s.Parameters.AddWithValue("@ID", pro_id);
                    s.ExecuteNonQuery();
                }
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
