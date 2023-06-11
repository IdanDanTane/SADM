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
    public partial class CreateShiftReport : Form
    {
        public CreateShiftReport()
        {
            InitializeComponent();
        }

        private void CreateShiftReport_Load(object sender, EventArgs e)
        {
            foreach (Product p in Program.Procducts)
            {
                dataGridView1.Rows.Add(false, p.Id, 0);
            }
        }

        private void proid_Click(object sender, EventArgs e)
        {

        }

        private void proid_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void crepo_Click(object sender, EventArgs e)
        {
            ShiftReport SR = new ShiftReport(ShiftID.Text, true);
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
                            SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[AddShiftReport]  @shiftID, @ProductID, @quantity", sqlConn.getConnection());
                            cmd.SelectCommand.Parameters.AddWithValue("@shiftID", SR.shiftID);
                            cmd.SelectCommand.Parameters.AddWithValue("@ProductID", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            cmd.SelectCommand.Parameters.Add(quanti);
                            sqlConn.Execute_non_query(cmd);
                        }
                    }
                    
                }
            }
        SR.GetProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
