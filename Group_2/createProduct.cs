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
            // create product

            try
            {
                Product p = this.createNewProduct();

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
            catch (Exception e1)
            {
                MessageBox.Show("could not create the product, plese try again");

            }

        }
            
        private Product createNewProduct()
        {
            if (string.IsNullOrWhiteSpace(productID.Text) || string.IsNullOrWhiteSpace(productName.Text) || string.IsNullOrWhiteSpace(pricePerTon.Text))
                throw new Exception(); // One or more of the textboxes are empty or contain only whitespace

            if (((!(Program.IsValidProducttID(productID.Text))) || (!(Program.IsValidNumbers(pricePerTon.Text)))))
                throw new Exception(); // One or more of the textboxes are not valid

            if (expirationDate.Value > DateTime.Today)
                throw new Exception();

            if (expirationDate.Value.Equals(DateTime.Today))
                throw new Exception();

            if (nothingChecked())
                throw new Exception();

            Product P = new Product(
              this.productID.Text,
              this.productName.Text,
              this.expirationDate.Value,
              decimal.Parse(this.pricePerTon.Text),
              (ProductType)Enum.Parse(typeof(ProductType), Type.Text.Replace(' ', '_')), false, true

          );
            return P;

        }
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
            if (expirationDate.Value > DateTime.Today)

                invalid_ExpDate.Show();
            else
                invalid_ExpDate.Hide();

            if (expirationDate.Value.Equals(DateTime.Today))
                invalid_ExpDate.Show();
            else
                invalid_ExpDate.Hide();


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
            if (nothingChecked())
                invalid_materials.Show();
            else 
                invalid_materials.Hide();
        }

        private void invalid_ProdID_Click(object sender, EventArgs e)
        {

        }

        private void invalid_ExpDate_Click(object sender, EventArgs e)
        {

        }

        private void productID_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(productID.Text)))
            {
                if (!(Program.IsValidProducttID(productID.Text)))
                    invalid_ProdID.Show();
                else
                    invalid_ProdID.Hide();
            }
            else
                invalid_ProdID.Show();
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
        private void invalid_materials_Click(object sender, EventArgs e)
        {

        }
    }
}
//