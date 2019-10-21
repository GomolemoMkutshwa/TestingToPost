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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }



        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //List of registered Lecturers 
            Dictionary<string, string> Lecturers = new Dictionary<string, string>();
            Lecturers.Add("Emily.com", "Cat");
            Lecturers.Add("Celiwe.com", "Water");
            Lecturers.Add("Lindo.com", "Milk");
            Lecturers.Add("Thato.com", "JuicySand");

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            String strr = "Select Name, Surname,Email, Password from Register where Email= '" + textBoxEmail.Text + "'and Password ='" + textBoxPassword.Text + "' ";
            SqlCommand cmd = new SqlCommand(strr, con);
            SqlDataAdapter da = new SqlDataAdapter(strr, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                textBoxEmail.Hide();
                textBoxPassword.Hide();
                labelEmail.Hide();
                labelPassword.Hide();
                btnRegister.Hide();
                buttonLogin.Hide();
                label3.Hide();
                label5.Show();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label5.Text = "Welcome you  are now logged in!";
                    btnCreateTest.Show();
                    btnTakeTest.Show();
                }
            

                if (textBoxEmail.Text == Lecturers["Emily.com"] && textBoxPassword.Text == Lecturers["Cat"])
                {
                    textBoxEmail.Hide();
                    textBoxPassword.Hide();
                    labelEmail.Hide();
                    labelPassword.Hide();
                    btnRegister.Hide();
                    buttonLogin.Hide();
                    label3.Hide();
                    label5.Show();
                    btnCreateTest.Show();
                 
                }
                else if (textBoxEmail.Text != Lecturers["Emily.com"] || textBoxPassword.Text != Lecturers["Cat"])
                {
                    label3.Show();
                    label3.Text = "Email or pssword is incorrect!";
                }


            }
        }
           

        
    
        private void Form1_Load(object sender, EventArgs e)
        {
            

           
            this.Hide();
            label5.Hide();
            label3.Hide();
            btnCreateTest.Hide();
            btnTakeTest.Hide();

        }

        private void linkLabelPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage form = new LoginPage();//Takes you to the registration form
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTest form = new CreateTest();
            form.Show();// For lecturer to create a test

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TakeTest form = new TakeTest();
            form.Show();//For Students to take a test
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
