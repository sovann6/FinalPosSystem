using POS_System.Folder_Forms;
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
    public partial class Loading : Form
    {
        float angle= 0;
        
        public Loading()
        {
            InitializeComponent();
            
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this); 
            guna2CircleProgressBar1.Value = 0;  
            label_value.Text = "0";  

            timer1.Start(); 
            timer2.Start(); 
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
        public Image RotateImage(Image img, float rotationAngle)
        {
            if (img == null) return null; // Prevent crashes if image is null

            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent); // Fix background issue
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.TranslateTransform(img.Width / 2, img.Height / 2);  // Move to center
                g.RotateTransform(rotationAngle);  // Rotate
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);  // Move back
                g.DrawImage(img, new Point(0, 0));  // Draw rotated image
            }
            return bmp;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value < 100)
            {
                guna2CircleProgressBar1.Value += 1; // Increase progress
                label_value.Text = guna2CircleProgressBar1.Value.ToString(); // Update label                
            }
            else
            {
                timer1.Stop();
                timer2.Stop(); 
                string fullname = Login.FullName;
                string Role= Login.RoleName;
                byte[] imgData = Login.Profile;
                if(imgData != null)
                {
                    using(MemoryStream ms =new MemoryStream(imgData))
                    {
                        Image img = Image.FromStream(ms);
                    }
                }
                if (Role == "admin" || Role == "Admin")
                {
                    Main_Admin main = new Main_Admin(fullname, imgData);
                    main.Show();
                    this.Hide();
                }
                else if (Role=="sale"||Role=="Sale") { 
                    Main_Sales main = new Main_Sales(fullname, Role, imgData);
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            angle += 5;  
            if (angle >= 360) angle = 0;  

            
            if (Properties.Resources.C__A__M__E__R__A_1_removebg_preview != null)
            {
                Logo.Image = RotateImage(Properties.Resources.C__A__M__E__R__A_1_removebg_preview, angle);
            }
        }
    }
}
