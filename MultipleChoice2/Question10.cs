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
    public partial class Question10 : Form
    {
        public Question10()
        {
            InitializeComponent();
        }

        private void Question10_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select questionNumber, question, optionA, optionB, optionC from CreateTests where questionNumber = '10' ", con);
            DataTable kk = new DataTable();
            cc.Fill(kk);

            txbxQuestNum.Text = kk.Rows[0][0].ToString();
            txbxQuestion.Text = kk.Rows[0][1].ToString();
            txbxOp1.Text = kk.Rows[0][2].ToString();
            txBxOp2.Text = kk.Rows[0][3].ToString();
            txbxOp3.Text = kk.Rows[0][4].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strr = "Insert into StudentAnswer( Answer) Values('"  + textBoxAnswer.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();
            String strrr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxOp1.Text + "' )";
            SqlCommand cmddd = new SqlCommand(strr, con);
            cmddd.ExecuteNonQuery();
            


            if (textBoxAnswer.Text != txbxOp1.Text)
            {
               
                
                
                lblFeedback.Text = "Wrong Answer";
                label7.Text = "TEST COMPLETED!";
                
                String strrrr = "Insert into ReportCard(Marks) Values('" + lblFeedback.Text + "' )";
                SqlCommand cmdddd = new SqlCommand(strrr, con);
                cmdddd.ExecuteNonQuery();

            }
            if (textBoxAnswer.Text == txbxOp1.Text)
            {
                
               
                lblFeedback.Text = "Correct";
                label7.Text = "TEST COMPLETED!";
                String strrrr = "Insert into ReportCard( Marks) Values('" + lblFeedback.Text + "' )";
                SqlCommand cmdddd = new SqlCommand(strrr, con);
                cmdddd.ExecuteNonQuery();

            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMemo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strrrr = "Insert into ReportCards(Marks) Values('" + lblFeedback.Text + "' )";
            SqlCommand cmdddd = new SqlCommand(strrrr, con);
            cmdddd.ExecuteNonQuery();
            Memorandum form = new Memorandum();
            form.Show();
        }
    }
}
