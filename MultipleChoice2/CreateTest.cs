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
using Register;

namespace MultipleChoice2
{
    public partial class CreateTest : Form
    {
        public CreateTest()
        {
            InitializeComponent();
        }

        private void CreateTest_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();

            List<CreateTest> ques = new List<CreateTest>();//Generic List <T>

            CreateQuestions q2 = new CreateQuestions();

            String str = "Insert into CreateTests(questionNumber , question, optionA, optionB, optionC) Values('" + txbxQuestNum.Text + "', '" + txbxQuestion.Text + "', '" + txbxOp1.Text + "', '" + txBxOp2.Text + "', '" + txbxOp3.Text + "' )";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            String strr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxOp1.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();

            //REPETITION OF QUESTION STENSIL TO CREATE QUESTIONS
           

            //Open the connection object
           
           
            CreateQuestions form = new CreateQuestions();
            form.Show();//Next question

            con.Close();//closing the connection object

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
        form.Show();//To stop creating more questions and this will also take you to the login form
        }
    }
}
