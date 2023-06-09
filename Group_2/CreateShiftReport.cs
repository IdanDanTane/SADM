﻿using Group_2;
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
            // create shift report 

            try
            {
                ShiftReport SR = newShiftR();

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
            catch (Exception e1)
            {
                MessageBox.Show("could not create the shift report, plese try again");

            }
        }
         private ShiftReport newShiftR()

        {

            if (nothingChecked())
                throw new Exception();

            int shiftID;
            int.TryParse(ShiftID.Text, out shiftID);

            ShiftReport SR = new ShiftReport(shiftID, true);

            return SR;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nothingChecked())
                invalid_products.Show();
            else
                invalid_products.Hide();
        }

        private void ShiftID_TextChanged(object sender, EventArgs e)
        {

        }
        private void EndshiftReport_Click(object sender, EventArgs e)
        {
            CreateShiftReport SR = new CreateShiftReport();
            SR.Show();
            this.Hide();
        }

        private void invalid_products_Click(object sender, EventArgs e)
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
