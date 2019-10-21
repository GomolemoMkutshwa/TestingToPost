using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoneDLL;

namespace MultipleChoice2
{
    public partial class Done : Form
    {
        public Done()
        {
            InitializeComponent();
        }

        private void Done_Load(object sender, EventArgs e)
        {

            Class1 newClass = new Class1();
            newClass.Print();
            Console.ReadLine();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
