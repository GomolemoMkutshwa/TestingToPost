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

namespace MultipleChoiceTask2
{
    /// <summary>
    /// Interaction logic for ViewStudents.xaml
    /// </summary>
    public partial class ViewStudents : Window
    {
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHJHS0A\SQLEXPRESS;Initial Catalog=ProgAssignmentTask12B;Integrated Security=True");
            con.Open();
            SqlDataAdapter cc = new SqlDataAdapter("Select Email from Register ", con);
            DataTable kk = new DataTable();


            cc.Fill(kk);

            textBox.Text = kk.Rows[0][2].ToString();
            textBox.Text = kk.Rows[1][2].ToString();
            textBox.Text = kk.Rows[2][2].ToString();
            textBox.Text = kk.Rows[3][2].ToString();
            textBox.Text = kk.Rows[4][2].ToString();
            textBox.Text = kk.Rows[5][2].ToString();
            textBox.Text = kk.Rows[6][2].ToString();
            textBox.Text = kk.Rows[7][2].ToString();
            textBox.Text = kk.Rows[8][2].ToString();
            textBox.Text = kk.Rows[9][2].ToString();
            textBox.Text = kk.Rows[10][2].ToString();
            textBox.Text = kk.Rows[11][2].ToString();
        }
    }
}
