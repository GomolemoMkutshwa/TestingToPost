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
    public partial class CreateQuestion5 : Form
    {
        public CreateQuestion5()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();

            String str = "Insert into CreateTests(questionNumber , question, optionA, optionB, optionC) Values('" + txbxQuestNum.Text + "', '" + txbxQuestion.Text + "', '" + txbxOp1.Text + "', '" + txBxOp2.Text + "', '" + txbxOp3.Text + "' )";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            String strr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxOp1.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();
            CreateQuestion6 form = new CreateQuestion6();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbxQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxQuestNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxOp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxOp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxOp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateQuestion5_Load(object sender, EventArgs e)
        {

        }
    }
}
