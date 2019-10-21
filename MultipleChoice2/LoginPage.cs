using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Register;
using System.Data.SqlClient;

namespace MultipleChoice2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

            label7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == textBoxConfirm.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
                con.Open();
              
                String str = "Insert into Register(Name, Surname, Email, Password, confirmPassword) Values('" + textBoxName.Text + "', '" + textBoxSurname.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "', '" + textBoxConfirm.Text + "' )";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

               
                label8.Text = "You can now Login";
                label7.Hide();
               

            }
            else if (textBoxPassword.Text!= textBoxConfirm.Text)
            {
                label7.Show();
                label7.Text = "Password does not match.";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
