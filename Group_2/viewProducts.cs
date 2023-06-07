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
    public partial class viewProducts : Form
    {
        public viewProducts()
        {
            InitializeComponent();
        }
        private void ViewProduct_Load(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            DataTable dt = new DataTable();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[ViewProduct] ", SC.getConnection());
            r.Fill(dt);
            viewProduct.DataSource = dt;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            manageProducts products = new manageProducts();
            products.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
