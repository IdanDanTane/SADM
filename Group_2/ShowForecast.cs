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
    public partial class ShowForecast : Form
    {
        Forecast current ;
        public ShowForecast(Forecast f)
        {
            InitializeComponent();
            current = f;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowForecast_Load(object sender, EventArgs e)
        {
            foreach (Product p in current.futureProducts.Keys)
            {
                dataGridView1.Rows.Add(p.Id, current.futureProducts[p]);
            }
            foreach (Material m in current.futureMaterials.Keys)
            {
                dataGridView2.Rows.Add(m.Id, current.futureMaterials[m]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }
    }
}
