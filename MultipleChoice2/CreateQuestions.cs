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
    public partial class CreateQuestions : CreateTest
    {
        public string questions { get; set; }
        public CreateQuestions()
        {
            InitializeComponent();
        }

        private void CreateQuestion2_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();

            

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
