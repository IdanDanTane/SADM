using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public partial class CreateForecast : Form
    {
        public CreateForecast()
        {
            InitializeComponent();
        }

        private void CreateForecast_Load(object sender, EventArgs e)
        {
            foreach(Product p in Program.Procducts)
            {
                dataGridView1.Rows.Add(false, p.Id);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nothingChecked())
                invalid_product.Show();
            else
                invalid_product.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {

            // create forcast 

            try
            {
                Forecast f = newForcast();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        if (((Boolean)dataGridView1.Rows[i].Cells[0].Value).ToString().Equals("True"))
                        {
                            {

                                f.futureProducts.Add(Program.seekProduct(dataGridView1.Rows[i].Cells[1].Value.ToString()), 0);
                            }
                        }

                    }
                }
                f.calculateForecast();
                ShowForecast sf = new ShowForecast(f);
                sf.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                MessageBox.Show("could not create the forcast, plese try again");

            }

           
        }

        private Forecast newForcast()
        {
            if(startDate.Value < DateTime.Today)
                throw new Exception();

            if (startDate.Value.Equals(DateTime.Today))
                throw new Exception();

            if (startDate.Value > endDate.Value)
                throw new Exception();

            if (startDate.Value.Equals(endDate.Value))
                throw new Exception();

            if (nothingChecked())
                throw new Exception();

            Forecast f = new Forecast(this.startDate.Value, this.endDate.Value, true);
            return f;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }

        private void invalidStart_Click(object sender, EventArgs e)
        {

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            startDate.CustomFormat = "yyyy-MM-dd";

            if (startDate.Value < DateTime.Today)
                invalidStart.Show();
            else
                invalidStart.Hide();

            if (startDate.Value.Equals(DateTime.Today))
                invalidStart.Show();
            else
                invalidStart.Hide();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            endDate.CustomFormat = "yyyy-MM-dd";

            if (startDate.Value > endDate.Value)
                invalidEnd.Show();
            else
                invalidEnd.Hide();


            if (startDate.Value.Equals(endDate.Value))
                invalidEnd.Show();
            else
                invalidEnd.Hide();
        }

        private void invalidEnd_Click(object sender, EventArgs e)
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
                        {

                            counter++;
                        }
                    }

                }
            }
            return counter == 0;
        }
    }

    }
