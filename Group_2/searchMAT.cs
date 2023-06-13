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

    public partial class searchMAT : Form
    {
        public Material temp;
        public searchMAT()
        {
            InitializeComponent();
            this.MATname.Enabled = false;
            this.RecivedDate.Enabled = false;
            this.priceperton.Enabled = false;
            this.minthersh.Enabled = false;
            this.Status.Enabled = false;
            this.Loc.Enabled = false;
            this.ExpDate.Enabled = false;
            this.AmountEX.Enabled = false;
            this.deleteMAT.Enabled = false;
            this.UpdateMAT.Enabled = false;
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
            if (Program.seekMaterial(MATID.Text.ToString()) == null)
            {
                MessageBox.Show("Material does not exist. please try again");
            }
            else
            {
                search_MAT.Enabled = false;
                deleteMAT.Enabled = true;
                UpdateMAT.Enabled = true;
                this.temp = Program.seekMaterial(MATID.Text.ToString());
                MATID.Enabled = false;
                this.MATname.AppendText(temp.Name);
                this.RecivedDate.Value = temp.recivedDate;
                this.priceperton.AppendText(temp.pricePerTon.ToString());
                this.minthersh.AppendText(temp.minimumThreshold.ToString());
                this.Status.SelectedItem=temp.Status;
                this.Loc.SelectedItem=temp.Location;
                this.ExpDate.Value = temp.expirationDate;
                this.AmountEX.AppendText(temp.amount.ToString());


                this.MATname.Enabled = true;
                this.RecivedDate.Enabled = true;
                this.priceperton.Enabled = true;
                this.minthersh.Enabled = true;
                this.Status.Enabled = true;
                this.Loc.Enabled = true;
                this.ExpDate.Enabled = true;
                this.AmountEX.Enabled = true; 
            }
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
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[MoveMaterialToArchive] @MaterialID", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@MaterialID", temp.Id);
            SC.Execute_non_query(r);
            temp.inArchive = true;

        }

        private void UpdateEMP_Click(object sender, EventArgs e)
        {
            // update material 

            try
            {
                Material ma = this.updateMaterial();
                SQL_CON SC = new SQL_CON();
                SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[UpdateMaterial] @MaterialID ,@Name ,@PricePerTone ,@MinimumThreshold ,@Status ,@warehouse ,@ReceivedDate ,@ExpirationDate ,@Amount", SC.getConnection());
                r.SelectCommand.Parameters.AddWithValue("@MaterialID", temp.Id);
                r.SelectCommand.Parameters.AddWithValue("@Name", this.MATname.Text);
                r.SelectCommand.Parameters.AddWithValue("@PricePerTone", this.priceperton.Text);
                r.SelectCommand.Parameters.AddWithValue("@MinimumThreshold", this.minthersh.Text);
                r.SelectCommand.Parameters.AddWithValue("@Status", this.Status.Text);
                r.SelectCommand.Parameters.AddWithValue("@warehouse", this.Loc.Text);
                string newDateTime = this.RecivedDate.Value.ToString("yyyy-MM-dd");
                r.SelectCommand.Parameters.AddWithValue("@ReceivedDate", newDateTime);
                newDateTime = this.ExpDate.Value.ToString("yyyy-MM-dd");
                r.SelectCommand.Parameters.AddWithValue("@ExpirationDate", newDateTime);
                r.SelectCommand.Parameters.AddWithValue("@Amount", this.AmountEX.Text);
                SC.Execute_non_query(r);
                temp.pricePerTon = decimal.Parse(this.priceperton.Text);
                temp.minimumThreshold = decimal.Parse(this.minthersh.Text);
                temp.Status = (Mstatus)Enum.Parse(typeof(Mstatus), this.Status.Text.Replace(' ', '_'));
                temp.Name = this.MATname.Text;
                temp.recivedDate = this.RecivedDate.Value;
                temp.expirationDate = this.ExpDate.Value;
                temp.amount = decimal.Parse(this.AmountEX.Text);
                temp.Location = (Warehouse)Enum.Parse(typeof(Warehouse), this.Loc.Text.Replace(' ', '_'));

            }
            catch (Exception e1)
            {
                MessageBox.Show("could not create the material, plese try again");

            }

        }

        private Material updateMaterial()
        {
            if (string.IsNullOrWhiteSpace(MATID.Text) || string.IsNullOrWhiteSpace(MATname.Text) || string.IsNullOrWhiteSpace(priceperton.Text) || string.IsNullOrWhiteSpace(minthersh.Text) || string.IsNullOrWhiteSpace(AmountEX.Text))
                throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

            if (((!(Program.IsValidMatID(MATID.Text))) || (!(Program.IsValidNumbers(priceperton.Text))) || (!(Program.IsValidNumbers(minthersh.Text)) || (!(Program.IsValidNumbers(AmountEX.Text))))))
                throw new Exception(); // One or more of the textboxes are not valid

            if (RecivedDate.Value > ExpDate.Value)
                throw new Exception();

            if (RecivedDate.Value.Equals(ExpDate.Value))
                throw new Exception();

            
            return temp;
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

        private void invalid_ExpDate_Click(object sender, EventArgs e)
        {

        }
    }
}
