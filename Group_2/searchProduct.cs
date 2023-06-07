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
    public partial class searchProduct : Form
    {
        public Product temp;
        public searchProduct()
        {
            InitializeComponent();
            this.productName.Enabled = false;
            this.expirationDate.Enabled = false;          
            this.Type.Enabled = false;         
            this.pricePerTon.Enabled = false;           
            this.deleteProduct.Enabled = false;           
            this.update_Product.Enabled = false;

            Type.DataSource = Enum.GetValues(typeof(ProductType));
        }

        private void button1_Click(object sender, EventArgs e) //search product
        {
            if (Program.seekProduct(productID.Text.ToString()) == null)
            {
                MessageBox.Show("Product does not exist. please try again");
            }
            else
            {
                search_Product.Enabled = false;
                deleteProduct.Enabled = true;
                update_Product.Enabled = true;
                this.temp = Program.seekProduct(productID.Text.ToString());
                productID.Enabled = false;             
                this.productName.AppendText(temp.Name);
                this.expirationDate.Value = temp.expirationDate;
                this.pricePerTon.AppendText(temp.pricePerTon.ToString());
                this.Type.SelectedItem = temp.ProductType;


                this.productName.Enabled = true;              
                this.expirationDate.Enabled = true;
                this.pricePerTon.Enabled = true;             
                this.Type.Enabled = true;
             
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            manageProducts products = new manageProducts();
            products.Show();
            this.Hide();
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void expirationDate_ValueChanged(object sender, EventArgs e)
        {
            expirationDate.CustomFormat = "yyyy-MM-dd";

        }

        private void productID_TextChanged(object sender, EventArgs e)
        {

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[MoveProductToArchive] @productID", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@productID", temp.Id);
            SC.Execute_non_query(r);
            Program.Procducts.Remove(temp);

        }

        private void update_Product_Click(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[UpdateProductl] @productId, @name, @expirationDate,  @ProductType, @pricePerTone", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@productID", temp.Id);
            r.SelectCommand.Parameters.AddWithValue("@name", this.productName.Text);
            r.SelectCommand.Parameters.AddWithValue("@ProductType", this.Type.Text);
             string newDateTime = this.expirationDate.Value.ToString("yyyy-MM-dd");       
            r.SelectCommand.Parameters.AddWithValue("@expirationDate", newDateTime);
            r.SelectCommand.Parameters.AddWithValue("@pricePerTone", this.pricePerTon.Text);        
            SC.Execute_non_query(r);           
            temp.pricePerTon = decimal.Parse(this.pricePerTon.Text);
            temp.ProductType = (ProductType)Enum.Parse(typeof(ProductType), this.Type.Text.Replace(' ', '_'));
            temp.Name = this.productName.Text;
            temp.expirationDate = this.expirationDate.Value;   
        }
    }
}
