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
using DoneDLL;
using System.Data.SqlClient;
using System.Data;

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Class1 newClass = new Class1();
            newClass.Print();
            Console.ReadLine();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select Name, Surname from Register ", con);
            DataTable kk = new DataTable();
            cc.Fill(kk);

            textBox.Text = kk.Rows[1][0].ToString();
            textBox1.Text = kk.Rows[0][1].ToString();
           
            



        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();


        }
    }
}
