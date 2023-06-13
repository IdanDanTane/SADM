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
            if (GetLoggedUserType().Equals("Food_technologist"))
            {
                showFoodTechnologistButtons();
            }
            if (GetLoggedUserType().Equals("Shift_manage"))
            {
                showShiftManagerButtons();
            }
            if (GetLoggedUserType().Equals("Stock_keeper"))
            {
                showStockKeeperButtons();
            }
            if (GetLoggedUserType().Equals("Warehouse_manager"))
            {
                showWareHouseManagerButtons();
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


        public void showFoodTechnologistButtons()
        {
            productionForm.Show();
            products.Show();
            forecast.Show();
        }

        public void showShiftManagerButtons()
        {
            EndshiftReport.Show();
            updateStock.Show();
        }

        public void showStockKeeperButtons()
        {
            updateStock.Show();
        }

        public void showWareHouseManagerButtons()
        {
            products.Show();
            materials.Show();
            updateStock.Show();
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

        private void incomeReport_Click(object sender, EventArgs e)
        {
            Create_fault CF = new Create_fault();

            CF.Show();
            this.Hide();
        }
        private void EndshiftReport_Click(object sender, EventArgs e)
        {
            CreateShiftReport SR = new CreateShiftReport();
            SR.Show();
            this.Hide();
        }




        private void updateStock_Click(object sender, EventArgs e)

        {
            if (GetLoggedUserType().Equals("Shift_manager"))
            {
                updateStock_ShiftManager updateStockForm = new updateStock_ShiftManager();
                updateStockForm.Show();
                this.Hide();
            }
            if (GetLoggedUserType().Equals("Stock_keeper"))
            {
                updateStock_StockKeeper updatestockForm = new updateStock_StockKeeper();
                updatestockForm.Show();
                this.Hide();
            }
            if (GetLoggedUserType().Equals("CEO"))
            {
                updateStock_CEO updateStockForm = new updateStock_CEO();
                updateStockForm.Show();
                this.Hide();

            }

            if (GetLoggedUserType().Equals("Warehouse_manager"))
            {
                updateStock_CEO updateStockForm = new updateStock_CEO();
                updateStockForm.Show();
                this.Hide();

            }
        }
            

        private void productionForm_Click(object sender, EventArgs e)
        {
            if (GetLoggedUserType().Equals("Food_technologist"))
            {
                ProductionFormForCEO ProductionCEO = new ProductionFormForCEO();
                ProductionCEO.Show();
                this.Hide();
            }
            if (GetLoggedUserType().Equals("CEO"))
            {
                ProductionFormForCEO ProductionCEO = new ProductionFormForCEO();
                ProductionCEO.Show();
            }

            if (GetLoggedUserType().Equals ("shift_Manager")){
                ProductionFormForShift pr = new ProductionFormForShift();
                pr.Show();

                this.Hide();
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void forecast_Click(object sender, EventArgs e)
        {
            CreateForecast cf = new CreateForecast();
            cf.Show();
        }

        private void updateStock_Click_1(object sender, EventArgs e)
        {
            if (GetLoggedUserType().Equals("Shift_manager"))
            {
                updateStock_ShiftManager updateStockForm = new updateStock_ShiftManager();
                updateStockForm.Show();
                this.Hide();
            }
            if (GetLoggedUserType().Equals("Stock_keeper"))
            {
                updateStock_StockKeeper updatestockForm = new updateStock_StockKeeper();
                updatestockForm.Show();
                this.Hide();
            }
            if (GetLoggedUserType().Equals("CEO"))
            {
                updateStock_CEO updateStockForm = new updateStock_CEO();
                updateStockForm.Show();
                this.Hide();

            }

        }
    }
}
