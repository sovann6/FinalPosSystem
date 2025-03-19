using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace POS_System.Folder_Forms
{
    public partial class Main_Sales : Form
    {
        private ButtonManager buttonManager;
        private string Role;
        public Main_Sales(string fullname,string role, byte[] img)
        {
            InitializeComponent();
            buttonManager = new ButtonManager(new Guna2Button[] { btndashbaord, btnPro,btnCat,btnOrder,txtExpense,txtIncome });
            Fullname.Text=fullname;
            if (img != null) {
                using (MemoryStream ms = new MemoryStream(img)) { 
                    Image image= Image.FromStream(ms);
                    Picture.Image = image;
                }
            }
            this.Role = role;
        }

        private void Main_Sales_Load(object sender, EventArgs e)
        {
            btndashbaord.PerformClick();
        }       

        private void btndashbaord_Click(object sender, EventArgs e)
        {
            label_TEXT.Text = "Dashboard";
            string RoleName = Login.RoleName;
            string Fullname = Login.FullName;
            byte[] Profile = Login.Profile;
            contianer(new Folder_Forms.Dashoard(RoleName, Fullname, Profile));
            buttonManager.SetActiveButton(btndashbaord);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Result= MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
            else
                return;
        }
        private void contianer(object _Form)
        {
            if (Panel_Content.Controls.Count > 0)
            {
                Panel_Content.Controls.Clear();
            }
            Form frm = _Form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Panel_Content.Controls.Add(frm);
            Panel_Content.Tag = frm;
            frm.Show();
        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            string RoleName = Login.RoleName;
            label_TEXT.Text = "Products";
            contianer(new Folder_Forms.Products(RoleName));
            buttonManager.SetActiveButton(btnPro);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            string RoleName = Login.RoleName;
            label_TEXT.Text = "Categories";
            contianer(new Folder_Forms.Category(RoleName));
            buttonManager.SetActiveButton(btnCat);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            label_TEXT.Text = "Orders";
            string Emp_ID = Login.Emp_ID;
            string Role = Login.RoleName;
            contianer(new Folder_Forms.OrderForm());
            buttonManager.SetActiveButton(btnOrder);
        }

        private void txtExpense_Click(object sender, EventArgs e)
        {
            if (Role == "sale")
            {
                MessageBox.Show("You do not have permission to view Expanse.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label_TEXT.Text = "Expanses";
            contianer(new Folder_Forms.Expense());
            buttonManager.SetActiveButton(txtExpense);
           
        }

        private void txtIncome_Click(object sender, EventArgs e)
        {
            if (Role == "sale")
            {
                MessageBox.Show("You do not have permission to view Income.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label_TEXT.Text = "Income";
            contianer(new Folder_Forms.Income());
            buttonManager.SetActiveButton(txtIncome);
            
        }
    }
}
