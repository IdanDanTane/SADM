using Group_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public partial class ProductionForm : Form
    {
        public ProductionForm()
        {
            InitializeComponent();
            os.DataSource = Enum.GetValues(typeof(OrderStatus));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nothingChecked())
                invalid_product.Show();
            else
                invalid_product.Hide();
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            foreach (Product p in Program.Procducts)
            {
                dataGridView1.Rows.Add(false, p.Id, 0);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {

            // create production form 

            try
            {
                ProductionRequirement PR = newProductionFormR();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        if (((Boolean)dataGridView1.Rows[i].Cells[0].Value).ToString().Equals("True"))
                        {
                            {
                                decimal de = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                SqlParameter quanti = new SqlParameter("@quantity", SqlDbType.Decimal);
                                quanti.Value = de;

                                SQL_CON sqlConn = new SQL_CON();
                                SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[Add_ProductionProduct]  @prID, @pid, @amount", sqlConn.getConnection());
                                cmd.SelectCommand.Parameters.AddWithValue("@prID", PR.ID);
                                cmd.SelectCommand.Parameters.AddWithValue("@PID", dataGridView1.Rows[i].Cells[1].Value.ToString());
                                cmd.SelectCommand.Parameters.AddWithValue("@amount", dataGridView1.Rows[i].Cells[2].Value.ToString());
                                sqlConn.Execute_non_query(cmd);
                            }
                        }

                    }
                }
                PR.GetProducts();
                PR.addToProComp();

            }
            catch (Exception e1)
            {
                MessageBox.Show("could not create the production form, plese try again");

            }
        }


        private ProductionRequirement newProductionFormR()
        {
            if (crDate.Value > trDate.Value)
                throw new Exception();

            if (crDate.Value.Equals(trDate.Value))
                throw new Exception();

            if (!(Program.IsValidNumbers(pr.Text)))
                throw new Exception();

            if (string.IsNullOrWhiteSpace(pr.Text))
                 throw new Exception();

            if (nothingChecked())
                throw new Exception();

            ProductionRequirement PR = new ProductionRequirement(textBox1.Text, crDate.Value, trDate.Value, decimal.Parse(this.pr.Text), (OrderStatus)Enum.Parse(typeof(OrderStatus), os.Text), true);
            return PR;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void invalidEnd_Click(object sender, EventArgs e)
        {

        }

        private void trDate_ValueChanged(object sender, EventArgs e)
        {
            trDate.CustomFormat = "yyyy-MM-dd";

            if (crDate.Value > trDate.Value)
                invalidEnd.Show();
            else
                invalidEnd.Hide();


            if (crDate.Value.Equals(trDate.Value))
                invalidEnd.Show();
            else
                invalidEnd.Hide();
        }

        private void crDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pr_TextChanged(object sender, EventArgs e)
        {

        }

        private void invalid_product_Click(object sender, EventArgs e)
        {

        }
        private bool nothingChecked()
        {
            int counter = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (((Boolean)dataGridView1.Rows[i].Cells[0].Value).ToString().Equals("True"))
                    {
                        counter++;

                    }
                }

            }
        
            return counter == 0;
        }
    }
}
