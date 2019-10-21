using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for Question7.xaml
    /// </summary>
    public partial class Question7 : Window
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();

            List<CreateTest> ques = new List<CreateTest>();//Generic List <T>



            String str = "Insert into CreateTests(questionNumber , question, optionA, optionB, optionC) Values('" + txbxNumber.Text + "', '" + txbxQuestion.Text + "', '" + txbxA.Text + "', '" + txbxB.Text + "', '" + txbxC.Text + "' )";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            String strr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxA.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();

            //REPETITION OF QUESTION STENSIL TO CREATE QUESTIONS


            //Open the connection object
            con.Close();//closing the connection object

            Question8 form = new Question8();
            form.Show();//Next question
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            MainWindow form = new MainWindow();
            form.Show();//To stop creating more questions and this will also take you to the login form
        }
    }
}
