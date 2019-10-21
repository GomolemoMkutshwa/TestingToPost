﻿using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for TakeTest.xaml
    /// </summary>
    public partial class TakeTest : Window
    {
        public TakeTest()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select questionNumber, question, optionA,optionB, optionC from CreateTests where questionNumber = '1' ", con);
            DataTable kk = new DataTable();
            cc.Fill(kk);

            txbxNum.Text = kk.Rows[0][0].ToString();
            txbxQue.Text = kk.Rows[0][1].ToString();
            txbxA.Text = kk.Rows[0][2].ToString();
            txbxB.Text = kk.Rows[0][3].ToString();
            txbxC.Text = kk.Rows[0][4].ToString();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strr = "Insert into StudentAnswer( Answer) Values('" + txbxAns.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();

            String strrr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxA.Text + "' )";
            SqlCommand cmddd = new SqlCommand(strr, con);
            cmddd.ExecuteNonQuery();


            if (txbxAns.Text != txbxA.Text)
            {
                txbxFeedback.Text = ("Wrong Answer!");


            }
            if (txbxAns.Text == txbxA.Text)
            {
                txbxFeedback.Text = ("CORRECT!");

            }
            con.Close();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strrrr = "Insert into ReportCards(Marks) Values('" + txbxFeedback.Text + "' )";
            SqlCommand cmdddd = new SqlCommand(strrrr, con);
            cmdddd.ExecuteNonQuery();
            Take2 form = new Take2();
            form.Show();
        }
    }
}
