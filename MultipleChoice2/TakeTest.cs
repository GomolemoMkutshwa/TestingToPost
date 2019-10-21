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
    public partial class TakeTest : Form
    {
        public TakeTest()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();

         

            String strrr = "Insert into ReportCards(Marks) Values('" + lblFeedback.Text + "' )";
            SqlCommand cmdddd = new SqlCommand(strrr, con);
            cmdddd.ExecuteNonQuery();

            TakingTheTest form = new TakingTheTest();
            form.Show();

            
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
        }
            

        private void btnMarks_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
                con.Open();
                SqlDataAdapter cc = new SqlDataAdapter("Select questionNumber, question, optionA,optionB, optionC from CreateTests  ", con);
                DataTable kk = new DataTable();
                cc.Fill(kk);

                txbxQuestNum.Text = kk.Rows[0][0].ToString();
                txbxQuestion.Text = kk.Rows[0][1].ToString();
                txbxOp1.Text = kk.Rows[0][2].ToString();
                txBxOp2.Text = kk.Rows[0][3].ToString();
                txbxOp3.Text = kk.Rows[0][4].ToString();


            }
         
          
        }

        private void txbxOp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strr = "Insert into StudentAnswer( Answer) Values('" + textBoxAnswer.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();
            String strrr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxOp3.Text + "' )";
            SqlCommand cmddd = new SqlCommand(strr, con);
            cmddd.ExecuteNonQuery();
            

            if (textBoxAnswer.Text != txbxOp3.Text)
            {
                lblFeedback.Text = "Wrong Answer";
                label3.Hide();
                label4.Hide();
                label5.Hide();
                txbxOp1.Hide();
                txBxOp2.Hide();
                txbxOp3.Hide();

                
            }
            if (textBoxAnswer.Text == txbxOp3.Text)
            {
                lblFeedback.Text = "Correct";
                label3.Hide();
                label4.Hide();
                label5.Hide();
                txbxOp1.Hide();
                txBxOp2.Hide();
                txbxOp3.Hide();
               

            }
        }

        private void txbxFeedback_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
