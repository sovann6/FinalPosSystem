using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System.Sub_Form.Orders_Form
{
    public partial class Orders : UserControl
    {
        public event EventHandler AddItem;

        public Orders()
        {
            InitializeComponent();
        }

        public string Product_Name
        {
            get => PName.Text;
            set => PName.Text = value;
        }

        public string Product_Price
        {
            get => lbtPrice.Text;
            set => lbtPrice.Text = value;
        }

        public Image Product_Image
        {
            get => PIcPro.Image;
            set => PIcPro.Image = value;
        }
        public int Product_ID { get; set; }
        public int Stock { get; set; }
        public decimal costPrice { get; set; }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            AddItem?.Invoke(this, EventArgs.Empty);
        }
    }
}
