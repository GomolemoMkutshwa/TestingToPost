using System;
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
using DoneDLL;

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for ViewMarks.xaml
    /// </summary>
    public partial class ViewMarks : Window
    {
        public ViewMarks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

           

           

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select Marks from ReportCards ", con);
            DataTable kk = new DataTable();


            cc.Fill(kk);

            txbxA1.Text = kk.Rows[0][0].ToString();
            txbxA2.Text = kk.Rows[1][0].ToString();
            txbxA3.Text = kk.Rows[2][0].ToString();
            txbxA4.Text = kk.Rows[3][0].ToString();
            txbxA5.Text = kk.Rows[4][0].ToString();
            txbxA6.Text = kk.Rows[5][0].ToString();
            txbxA7.Text = kk.Rows[6][0].ToString();
            txbxA8.Text = kk.Rows[7][0].ToString();
            txbxA9.Text = kk.Rows[8][0].ToString();
            txbxA10.Text = kk.Rows[9][0].ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();


            //print message from DLL
            Class1 newClass = new Class1();
           textBox.Text =  newClass.ToString();
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
