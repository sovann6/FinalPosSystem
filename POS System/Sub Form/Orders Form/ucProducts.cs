using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Sub_Form.Orders_Form
{
    public partial class ucProducts : UserControl
    {
        public event EventHandler onSelect=null;
        public ucProducts()
        {
            InitializeComponent();
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {

        }

        private void ProductPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
        public int id { get; set; }
        public string qty { get; set; }
        public string PName {
            get { return Product_Name.Text; }
            set { Product_Name.Text = value; }
        }
        public string Price
        {
            get { return lbPrice.Text; }
            set { lbPrice.Text = value; }
        }
        public Image ProductImage
        {
            get { return ProductPic.Image; }
            set { ProductPic.Image = value; }
        }
    }
}
