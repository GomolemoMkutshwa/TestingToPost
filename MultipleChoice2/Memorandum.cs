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
    public partial class Memorandum : Form
    {
        public Memorandum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select Answer from StudentAnswer" , con);
            DataTable kk = new DataTable();
            cc.Fill(kk);

            txbxMyAns1.Text = kk.Rows[0][0].ToString();
            txbxMyAns2.Text = kk.Rows[1][0].ToString();
            txbxMyAns3.Text = kk.Rows[2][0].ToString();
            txbxMyAns4.Text = kk.Rows[3][0].ToString();
            txbxMyAns5.Text = kk.Rows[4][0].ToString();
            txbxMyAns6.Text = kk.Rows[5][0].ToString();
            txbxMyAns7.Text = kk.Rows[6][0].ToString();
            txbxMyAns8.Text = kk.Rows[7][0].ToString();
            txbxMyAns9.Text = kk.Rows[8][0].ToString();
            txbxMyAns10.Text = kk.Rows[9][0].ToString();

        }

        private void Memorandum_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select CorrectAnswers from Memorandum", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            ViewMarks marks = new ViewMarks();
            marks.Show();
        }
    }
}
