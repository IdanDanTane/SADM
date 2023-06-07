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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
            hideAllButtons();
            if (GetLoggedUserType().Equals("CEO"))
            {
                showCEOButtons();
            }
        }
        public void hideAllButtons()
        {
            productionForm.Hide();
            products.Hide();
            materials.Hide();
            customers.Hide();
            employees.Hide();
            updateStock.Hide();
            incomeReport.Hide();
            EndshiftReport.Hide();
            forecast.Hide();
        }

        public void showCEOButtons()
        {
            productionForm.Show();
            products.Show();
            materials.Show();
            customers.Show();
            employees.Show();
            updateStock.Show();
            incomeReport.Show();
            EndshiftReport.Show();
            forecast.Show();
        }

        private string GetLoggedUserType()
        {
            return Login.GetEmployeeType();
        }

        private void materials_Click(object sender, EventArgs e)
        {
            manageMaterials MAT = new manageMaterials();
            MAT.Show();
            this.Hide();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            manageCustomers manageCustomers = new manageCustomers();  
            manageCustomers.Show();
            this.Hide();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            manageEmployees EMP = new manageEmployees();
            EMP.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void products_Click(object sender, EventArgs e)
        {
            manageProducts Products = new manageProducts();
            Products.Show();
            this.Hide();

        }
    }
}
