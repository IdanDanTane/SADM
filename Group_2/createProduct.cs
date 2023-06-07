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
                this.productID.Text,
                this.expirationDate.Value,
                decimal.Parse(this.pricePerTon.Text),
                (ProductType)Enum.Parse(typeof(ProductType), Type.Text.Replace(' ', '_')),true
            );

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string material = row.Cells["getMaterials"].Value.ToString();
                string amount = row.Cells["Amount"].Value.ToString();


                if (row.Cells["getMaterials"] is DataGridViewComboBoxCell comboBoxCell)
                {
                    string selectedValue = comboBoxCell.Value?.ToString();


                }


            }
        }

        private void createProduct_Load(object sender, EventArgs e)
        {

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
    }
}
