﻿using System;
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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void Question3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select questionNumber, question, optionA,optionB, optionC from CreateTests where questionNumber = '3' ", con);
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
            String strr = "Insert into StudentAnswer( Answer) Values('" + textBoxAnswer.Text + "' )";
            SqlCommand cmdd = new SqlCommand(strr, con);
            cmdd.ExecuteNonQuery();
            String strrr = "Insert into Memorandum( CorrectAnswers) Values('" + txbxOp1.Text + "' )";
            SqlCommand cmddd = new SqlCommand(strr, con);
            cmddd.ExecuteNonQuery();

            if (textBoxAnswer.Text != txbxOp1.Text)
            {
                lblFeedback.Text = "Wrong Answer!";
                label3.Hide();
                label4.Hide();
                label5.Hide();
                txbxOp1.Hide();
                txBxOp2.Hide();
                txbxOp3.Hide();

            }
            if (textBoxAnswer.Text == txbxOp1.Text)
            {
                lblFeedback.Text = "Correct!";
                label3.Hide();
                label4.Hide();
                label5.Hide();
                txbxOp1.Hide();
                txBxOp2.Hide();
                txbxOp3.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strrrr = "Insert into ReportCards(Marks) Values('" + lblFeedback.Text + "' )";
            SqlCommand cmdddd = new SqlCommand(strrrr, con);
            cmdddd.ExecuteNonQuery();
            Question4 form = new Question4();
            form.Show();
        }
    }
}
