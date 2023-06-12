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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Group_2
{
    public partial class createProduct : Form
    {
        public createProduct()
        {
            InitializeComponent();
            Type.DataSource = Enum.GetValues(typeof(ProductType));

            

        }
        //
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            Product p = new Product(
                this.productID.Text,
                this.productName.Text,
                this.expirationDate.Value,
                decimal.Parse(this.pricePerTon.Text),
                (ProductType)Enum.Parse(typeof(ProductType), Type.Text.Replace(' ', '_')),false,true

            );
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (((Boolean)dataGridView1.Rows[i].Cells[0].Value).ToString().Equals("True"))
                    {
                        {
                           decimal de = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                            SqlParameter quanti = new SqlParameter("@quantity",SqlDbType.Decimal);
                            quanti.Value = de;

                            SQL_CON sqlConn = new SQL_CON();
                            SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[AddProductMaterial]  @productID, @MaterialID, @quantity", sqlConn.getConnection());
                            cmd.SelectCommand.Parameters.AddWithValue("@productID", p.Id);
                            cmd.SelectCommand.Parameters.AddWithValue("@MaterialID", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            cmd.SelectCommand.Parameters.Add(quanti);
                            sqlConn.Execute_non_query(cmd);
                        }
                    }
                   
                }
            }
            p.GetMaterials();
            }
            
            /*
            //((DataTable)dataGridView1.DataSource).Columns[0].ColumnName = "chk";
            //if (((DataTable)dataGridView1.DataSource).AsEnumerable().Any(row => row.Field<bool>("chk")))
            {
                //var rows = (((DataTable)dataGridView1.DataSource).AsEnumerable().Where(row => row.Field<bool>(0)).ToList());
                //foreach (var row in rows)
                {
                    SQL_CON sqlConn = new SQL_CON();
                    SqlDataAdapter cmd = new SqlDataAdapter("INSERT INTO [dbo].[ProductMaterial]  values(@PID, @MID, @AM", sqlConn.getConnection());
                    cmd.SelectCommand.Parameters.AddWithValue("@PID", this.productID.Text);
                    cmd.SelectCommand.Parameters.AddWithValue("@MID", row.Field<string>("Material Id"));
                    cmd.SelectCommand.Parameters.AddWithValue("@AM", row.Field<decimal>("Amount"));
                    sqlConn.Execute_non_query(cmd);
                }
            }
            p.GetMaterials();

        }*/
        private void createProduct_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
           // dataGridView1.DataSource = Program.Materials;
            foreach (Material m in Program.Materials)
            {
                dataGridView1.Rows.Add(false,m.Id, 0);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void expirationDate_ValueChanged(object sender, EventArgs e)
        {
            expirationDate.CustomFormat = "yyyy-MM-dd";

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Back_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//