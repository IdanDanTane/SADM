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
            if (!(string.IsNullOrWhiteSpace(MATID.Text)))
            {
                if (!(Program.IsValidMatID(MATID.Text)))
                    invalid_matID.Show();
                else
                    invalid_matID.Hide();
            }
            else
                invalid_matID.Show();
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

    

        private void UpdateEMP_Click(object sender, EventArgs e)
        {
            // create material 

            try
            {
                Material ma = this.createMaterial();


            }
            catch (Exception e1)
            {
                MessageBox.Show("could not update the material, plese try again");

            }
        }

        private Material createMaterial()
        {
            if (string.IsNullOrWhiteSpace(MATID.Text) || string.IsNullOrWhiteSpace(MATname.Text) || string.IsNullOrWhiteSpace(priceperton.Text) || string.IsNullOrWhiteSpace(minthersh.Text) || string.IsNullOrWhiteSpace(AmountEX.Text))
                throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

            if (((!(Program.IsValidMatID(MATID.Text))) || (!(Program.IsValidNumbers(priceperton.Text))) || (!(Program.IsValidNumbers(minthersh.Text)) || (!(Program.IsValidNumbers(AmountEX.Text))))))
                throw new Exception(); // One or more of the textboxes are not valid

            if (RecivedDate.Value > ExpDate.Value)
                throw new Exception();

            if (RecivedDate.Value.Equals(ExpDate.Value))
                throw new Exception();

            Material m = new Material(this.MATID.Text, this.MATname.Text, decimal.Parse(this.priceperton.Text), decimal.Parse(this.minthersh.Text),
              (Mstatus)Enum.Parse(typeof(Mstatus), this.Status.Text.Replace(' ', '_')), (Warehouse)Enum.Parse(typeof(Warehouse), this.Loc.Text.Replace(' ', '_')),
              this.RecivedDate.Value, this.ExpDate.Value, decimal.Parse(this.AmountEX.Text), false, true);
            
            return m;
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (RecivedDate.Value > ExpDate.Value)
                invalid_ExpDate.Show();
            else
                invalid_ExpDate.Hide();


            if (RecivedDate.Value.Equals(ExpDate.Value))
               invalid_ExpDate.Show();
            else
               invalid_ExpDate.Hide();

            
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void invalid_matID_Click(object sender, EventArgs e)
        {

        }

        private void invalid_ExpDate_Click(object sender, EventArgs e)
        {

        }

        private void AmountEX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
