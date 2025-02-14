﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Main_Admin : Form
    {
        private ButtonManager buttonManager;
        public Main_Admin(string Fullname, byte[] Profile)
        {
            InitializeComponent();
            buttonManager = new ButtonManager(new Guna2Button[] { btndashbaord, btemp, btPro, btcate, btOrder });
            fULLNAME.Text = Fullname;
            
            if (Profile != null) { 
                MemoryStream ms= new MemoryStream(Profile);
                Image img= Image.FromStream(ms);
                Picture.Image = img;
            }
        }

        private void Main_Admin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            btndashbaord.PerformClick();
        }

        private void btndashbaord_Click(object sender, EventArgs e)
        {
            label_TEXT.Text = "Dashboard";
            string RoleName = Login.RoleName;
            string Fullname= Login.FullName;
            byte[] Profile = Login.Profile;
            contianer(new Folder_Forms.Dashoard(RoleName,Fullname,Profile));
            buttonManager.SetActiveButton(btndashbaord);
        }
        private void contianer(object _Form)
        {
            if (panel_container.Controls.Count>0)
            {
                panel_container.Controls.Clear();
            }
            Form frm= _Form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(frm);
            panel_container.Tag = frm;
            frm.Show();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label_TEXT.Text = "Employees";
            contianer(new Folder_Forms.Employee());
            buttonManager.SetActiveButton(btemp);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_TEXT.Text = "Products";
            contianer(new Folder_Forms.Products());
            buttonManager.SetActiveButton(btPro);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            contianer(new Folder_Forms.Category());
            buttonManager.SetActiveButton(btcate);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            buttonManager.SetActiveButton(btOrder);
            contianer(new Folder_Forms.OrderForm());
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
