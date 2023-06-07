using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_2
{

    public partial class createMAT : Form
    {
        public createMAT()
        {
            InitializeComponent();
            Loc.DataSource = Enum.GetValues(typeof(Warehouse));
            Status.DataSource = Enum.GetValues(typeof(Mstatus));
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
                    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void search_Employee_Click(object sender, EventArgs e)
        {
          
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeBirthDate_ValueChanged(object sender, EventArgs e)
        {
            RecivedDate.CustomFormat = "yyyy-MM-dd";
        }

        private void EmployeeEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeType_choose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageMaterials MAT = new manageMaterials();
            MAT.Show();
            this.Hide();

        }

        private void deleteEMP_Click(object sender, EventArgs e)
        {
           

        }

        private void UpdateEMP_Click(object sender, EventArgs e)
        {
            Material m = new Material(this.MATID.Text, this.MATname.Text, decimal.Parse(this.priceperton.Text), decimal.Parse(this.minthersh.Text),
                (Mstatus)Enum.Parse(typeof(Mstatus), this.Status.Text.Replace(' ', '_')), (Warehouse)Enum.Parse(typeof(Warehouse), this.Loc.Text.Replace(' ', '_')),
                this.RecivedDate.Value, this.ExpDate.Value, decimal.Parse(this.AmountEX.Text), true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
