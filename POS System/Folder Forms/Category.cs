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
    public partial class Category : Form
    {
        private string role;
        public Category(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand s = new SqlCommand("sp_Cat", DataConnection.DataCon);
                s.CommandType = CommandType.StoredProcedure;
                SqlDataReader r = s.ExecuteReader();
                DatagridviewCat.RowTemplate.Height = 80;
                DatagridviewCat.Rows.Clear();
                while (r.Read())
                {
                    int CatID = Convert.ToInt32(r[0].ToString());
                    byte[] img = null;
                    if (r[1] != DBNull.Value)
                    {
                        img = (byte[])r[1];
                    }
                    string Cat_Name = r[2] + "";
                    string Des = r[3].ToString();
                    DatagridviewCat.Rows.Add(CatID, img, Cat_Name, Des);
                }
                r.Close();
                s.Dispose();
                SqlCommand cmd = new SqlCommand("sp_CountCat", DataConnection.DataCon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                   string count = rd[0].ToString();
                    TotalCate.Text = count;
                }
                rd.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
            if (txtSearch.Text=="")
            {
                Category_Load(sender, e);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_Search_Category", DataConnection.DataCon);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@temp_search", txtSearch.Text);
                    DatagridviewCat.Rows.Clear();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        int CatID = Convert.ToInt32(r[0].ToString());
                        byte[] img = null;
                        if (r[1] != DBNull.Value)
                        {
                            img = (byte[])r[1];
                        }
                        string Cat_Name = r[2] + "";
                        string Des = r[3].ToString();
                        DatagridviewCat.Rows.Add(CatID, img, Cat_Name, Des);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sub_Form.Category_Form.Add _add = new Sub_Form.Category_Form.Add();
            if (_add.ShowDialog() == DialogResult.OK)
            {
                Category_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DatagridviewCat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Category to Edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int CatID = Convert.ToInt32(DatagridviewCat.SelectedRows[0].Cells[0].Value);
            byte[] img = (byte[])DatagridviewCat.SelectedRows[0].Cells[1].Value;
            string CatName = DatagridviewCat.SelectedRows[0].Cells[2].Value.ToString();
            string Des = DatagridviewCat.SelectedRows[0].Cells[3].Value.ToString();
            Sub_Form.Category_Form.Update _update = new Sub_Form.Category_Form.Update(CatID, img, CatName, Des);
            if (_update.ShowDialog() == DialogResult.OK)
            {
                Category_Load(sender, e);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (role.Equals("sale"))
            {
                //Check if the user has selected a category to delete (if not, show a warning message
                MessageBox.Show("You do not have permission to delete a category", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DatagridviewCat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Category to Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int Cat_id = Convert.ToInt32(DatagridviewCat.SelectedRows[0].Cells[0].Value);
            string CatName = DatagridviewCat.SelectedRows[0].Cells[2].Value.ToString();
            DialogResult =MessageBox.Show($"Are you sure you want to delete this Category {CatName}", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes) {
                DeleteCategory(Cat_id);
                Category_Load(sender, e);
            }

        }
        private void DeleteCategory(int CatID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteCategory", DataConnection.DataCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", CatID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
