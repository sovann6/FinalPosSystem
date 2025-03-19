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

namespace POS_System.Sub_Form.Expanse
{
    public partial class AddExpanse : Form
    {
        private string EmpId;
        public AddExpanse(string EmpID)
        {
            InitializeComponent();
            this.EmpId = EmpID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddExpanse_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InserExpanse", DataConnection.DataCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Amount", txtExpanseAmount.Text);
                cmd.Parameters.AddWithValue("@ExpanseDate", dateTime.Value);
                cmd.Parameters.AddWithValue("@EmpID",EmpId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Expanse Insert Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex) {
                MessageBox.Show($"Error Database:{ex}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
