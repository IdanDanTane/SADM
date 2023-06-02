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
    public partial class viewEMP : Form
    {
        public viewEMP()
        {
            InitializeComponent();
        }

        private void viewEMP_Load(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            DataTable dt = new DataTable();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[Get_all_employees] ", SC.getConnection());
            r.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageEmployees EMP = new manageEmployees();
            EMP.Show();
            this.Hide();
        }
    }
}
