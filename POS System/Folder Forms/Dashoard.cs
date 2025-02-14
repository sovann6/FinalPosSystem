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

namespace POS_System.Folder_Forms
{
    public partial class Dashoard : Form
    {
        public Dashoard(string role,string fullname, byte[] img)
        {
            InitializeComponent();
            label_Name.Text =fullname;
            labelPosition.Text=role;
            if (img != null) {
                using (MemoryStream ms = new MemoryStream(img)) {
                    Image image= Image.FromStream(ms);
                    guna2CirclePictureBox1.Image= image;
                }
            }
            
        }

        private void Dashoard_Load(object sender, EventArgs e)
        {
            int currentHour = DateTime.Now.Hour;  
            Time.Text =  GetTimeOfDay(currentHour) + "!";
            string countTotalEmp = "SELECT COUNT(*) FROM tbl_Employees;";
            SqlCommand s = new SqlCommand(countTotalEmp, DataConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            while (r.Read())
            {
                string total = r[0] + "";
                label_totalemp.Text = total;
            }
            r.Close();
            s.Dispose();
            string RoleAdmin = "SELECT COUNT(*) FROM tbl_Employees\r\n WHERE roles= 'admin';";
            SqlCommand s1 = new SqlCommand(RoleAdmin, DataConnection.DataCon);
            SqlDataReader r1 = s1.ExecuteReader();
            while (r1.Read())
            {
                string total = r1[0] + "";
                label_Admin.Text= total;
            }
            r1.Close();
            s1.Dispose();
            string RoleSale = " SELECT COUNT(*) FROM tbl_Employees\r\n WHERE roles= 'sale';";
            SqlCommand s2 = new SqlCommand(RoleSale, DataConnection.DataCon);
            SqlDataReader r2 = s2.ExecuteReader();
            while (r2.Read())
            {
                string total = r2[0] + "";
                label_Sale.Text = total;
            }
            r2.Close();
            s2.Dispose();
        }
        private string GetTimeOfDay(int hour)
        {
            if (hour >= 5 && hour < 12)
                return "Good Morning";
            else if (hour >= 12 && hour < 17)
                return "Good Afternoon";
            else if (hour >= 17 && hour < 21)
                return "Good Evening";
            else
                return "Good Night";
        }
        private static void QueryCount()
        {
            
               
        }
    }
}
