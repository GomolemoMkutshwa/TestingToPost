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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
        //List of registered Lecturers  

        Dictionary<string, string> Lecturers = new Dictionary<string, string>();
         
        public MainWindow()
        {
            InitializeComponent();
        }
        
    
      
        private void button_Click(object sender, RoutedEventArgs e)
        {
           

                if (txbxEmail.Text == "Emily.com" && txbxPass.Text =="Cat")
                {

                    CreateTest form = new CreateTest();
                    form.Show();// For lecturer to create a test
                }

                 else 
                {
                    MessageBox.Show("INCORRECT USERNAME OR PASSWORD TRY AGAIN");
                }


            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Register form = new Register();
            form.Show();// For lecturer to create a test
        }
    }

}