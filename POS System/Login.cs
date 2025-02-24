using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Login : Form
    {
        public static Image Image { get; private set; }
        public static string FullName {  get; set; }
        public static string RoleName { get; set; }
        public static byte[] Profile { get; set; }
        public static string Emp_ID { get; set; }
        public Login()
        {
            InitializeComponent();
            Role.SelectedIndexChanged += Role_SelectedIndexChanged;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            DataConnection.ConnectionDB();
            try
            {
                Pass.PasswordChar = '*';
                string QueryRole = "SELECT DISTINCT roles FROM tbl_Employees";
                SqlCommand s=new SqlCommand(QueryRole,DataConnection.DataCon);
                SqlDataReader dr = s.ExecuteReader();
                Role.Items.Clear();
                while (dr.Read()) {
                    Role.Items.Add(dr["roles"].ToString());
                }
                dr.Close();
                s.Dispose();
            }
            catch(Exception ex) { MessageBox.Show($"Failed:{ex}","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            Role.SelectedIndex = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Users.Text.Trim();
            string password = Pass.Text.Trim();
            string role = Role.SelectedItem.ToString();
            try
            {
                string QueryLogIn = $"\tSELECT Emp_id,first_name+' '+last_name AS FullName,Image,username,password,roles from tbl_Employees WHERE username='{username}' AND password='{password}' AND roles='{role}'";
                SqlCommand s=new SqlCommand(QueryLogIn,DataConnection.DataCon);
                SqlDataReader dr = s.ExecuteReader();                
                if (dr.Read()) {
                    byte[] profileBytes = (byte[])dr["Image"];
                    Login.Profile = profileBytes;
                    string Emp_ID = dr["Emp_id"].ToString();
                    Login.Emp_ID = Emp_ID;
                    string Roles=Role.Text.Trim();
                    FullName=dr["FullName"].ToString();
                    DialogResult result = MessageBox.Show("Wellcome : "+FullName+" to our POS System!","Wellcome",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        new Loading().Show();
                        this.Hide();
                    }

                    else
                    {
                        dr.Close();
                        s.Dispose();
                        return;
                    }
                }
                else {
                    MessageBox.Show("Invaled Password or Username And Role","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Users.Clear();
                    Pass.Clear();
                    Role.SelectedIndex = 0;
                }
                dr.Close();
                s.Dispose();
            }
            catch(Exception ex) { MessageBox.Show($"Error:{ex}"); }
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Role.SelectedIndex != -1) {
                RoleName = Role.SelectedItem.ToString();
            }
        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpass.Checked)
            {
                Pass.PasswordChar = '\0';
            }
            else
            {
                Pass.PasswordChar = '*';
            }
        }

        private void Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Role_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnLogin.PerformClick();    
            }
        }
    }
}
