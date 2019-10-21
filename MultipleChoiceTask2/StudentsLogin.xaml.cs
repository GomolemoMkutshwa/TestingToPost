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
using System.Data;

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for StudentsLogin.xaml
    /// </summary>
    public partial class StudentsLogin : Window
    {



        public StudentsLogin()
        {
            InitializeComponent();
        }

        string dbConnectionString = @"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True";
        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(dbConnectionString);

            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    // To validate registered users
                    String strr = "Select COUNT(1) from Register where Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(strr, con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Email", txbxEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", txbxPass.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        
                        TakeTest form = new TakeTest();
                        form.Show();
                        this.Close();

                    }
                    
                    else
                    {
                        MessageBox.Show("INCORRECT USERNAME AND PASSWORD");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();

            }

        }
    }
}