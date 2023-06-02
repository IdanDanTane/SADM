using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public partial class manageEmployees : Form
    {
        public manageEmployees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateEmployee createEMP = new CreateEmployee();
            createEMP.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            searchEMP searchEMP = new searchEMP();
            searchEMP.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewEMP view = new viewEMP();
            view.Show();
            this.Hide();
        }
    }
}
