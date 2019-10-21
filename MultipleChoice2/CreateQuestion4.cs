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
    public partial class CreateQuestion4 : Form
    {
        public CreateQuestion4()
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
            CreateQuestion5 form = new CreateQuestion5();
            form.Show();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void CreateQuestion4_Load(object sender, EventArgs e)
        {

        }
    }
}
