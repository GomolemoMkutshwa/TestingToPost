using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoice2
{
    public partial class Report : ViewMarks
    {
        public string marks { get; set; }

        public delegate int CalculateMarksDelegate(int high, int low, int avg);
        public Report()
        {
            InitializeComponent();
           
        }

        public int results(int high, int low, int avg)
        {
            return int.MaxValue;
            

        }
        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Done form = new Done();
            form.Show();
        }
    }
}
