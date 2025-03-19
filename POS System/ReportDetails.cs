using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class ReportDetails
    {
        public int No {  get; set; }
        public string PName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get { return Price * Qty; } }
        public ReportDetails() { 
            
        }

        public ReportDetails(int no, string pName, decimal price, int qty)
        {
            No = no;
            PName = pName;
            Price = price;
            Qty = qty;
        }
    }
}
