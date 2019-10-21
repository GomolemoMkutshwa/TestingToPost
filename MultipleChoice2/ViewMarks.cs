using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultipleChoice2
{
    public partial class ViewMarks : Form
    {
        public ViewMarks()
        {
            InitializeComponent();
        }

        private void ViewMarks_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<ViewMarks> ques = new List<ViewMarks>();//Generic List to store student marks<T>

            Report q2 = new Report();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select Marks from ReportCards ", con);
            DataTable kk = new DataTable();
           

            cc.Fill(kk);

            txbxA1.Text = kk.Rows[0][0].ToString();
            txbxA2.Text = kk.Rows[1][0].ToString();
            txbxA3.Text = kk.Rows[2][0].ToString();
            txbxA4.Text = kk.Rows[3][0].ToString();
            txbxA5.Text = kk.Rows[4][0].ToString();
            txbxA6.Text = kk.Rows[5][0].ToString();
            txbxA7.Text = kk.Rows[6][0].ToString();
            txbxA8.Text = kk.Rows[7][0].ToString();
            txbxA9.Text = kk.Rows[8][0].ToString();
            txbxA10.Text = kk.Rows[9][0].ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Report form = new Report();
            form.Show();
        }
    }
}
