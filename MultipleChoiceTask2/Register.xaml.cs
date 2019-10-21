using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txbxPass.Text == txbxConfirm.Text)
            {
               
                con.Open();

                String str = "Insert into Register(Name, Surname, Email, Password, confirmPassword) Values('" + txbxName.Text + "', '" + txbxSurname.Text + "', '" + txbxEmail.Text + "', '" + txbxPass.Text + "', '" + txbxConfirm.Text + "' )";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                StudentsLogin form = new StudentsLogin();
                form.Show();
                

            }
            else if (txbxPass.Text != txbxConfirm.Text)
            {
                MessageBox.Show("PASSWORD DOES NOT MATCH!");

            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
    

