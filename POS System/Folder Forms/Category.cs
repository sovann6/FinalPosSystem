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
        public Category()
        {
            InitializeComponent();
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
    }
}
