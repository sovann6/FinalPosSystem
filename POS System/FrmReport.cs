using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        public void SetReportData(List<ReportDetails> arr)
        {
            CrystalReport11.SetDataSource(arr);
        }
        public void Parameter(int index,object value)
        {
            CrystalReport11.SetParameterValue(index, value);
        }
        public void Print(int n,bool col, int start,int end)
        {
            CrystalReport11.PrintToPrinter(n, col, start, end);
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {

        }
    }
}
