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
        public Main_Sales(string fullname,string role, byte[] img)
        {
            InitializeComponent();
            buttonManager = new ButtonManager(new Guna2Button[] { btndashbaord, btnPro,btnCat,btnOrder });
            Fullname.Text=fullname;
            if (img != null) {
                using (MemoryStream ms = new MemoryStream(img)) { 
                    Image image= Image.FromStream(ms);
                    Picture.Image = image;
                }
            }
        }

        private void Main_Sales_Load(object sender, EventArgs e)
        {
            
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
            new Login().Show();
            this.Hide();
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
            label_TEXT.Text = "Dashboard";
            string RoleName = Login.RoleName;
            string Fullname = Login.FullName;
            byte[] Profile = Login.Profile;
            contianer(new Folder_Forms.Products());
            buttonManager.SetActiveButton(btnPro);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            buttonManager.SetActiveButton(btnCat);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            buttonManager.SetActiveButton(btnOrder);
        }
    }
}
