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

        }

        private void button2_Click(object sender, EventArgs e) { 
        
            Forecast f = new Forecast(this.startDate.Value, this.endDate.Value, true);
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

        private void button1_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }
    }

    }

