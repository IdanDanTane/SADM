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
    public partial class viewCUST : Form
    {
        public viewCUST()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewCUST_Load(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            DataTable dt = new DataTable();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[view_Customer] ", SC.getConnection());
            r.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageCustomers manangeCUST = new manageCustomers();
            manangeCUST.Show();
            this.Hide();
        }
    }
}
