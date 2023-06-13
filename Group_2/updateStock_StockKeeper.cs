using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_2
{
    public partial class updateStock_StockKeeper : Form
    {
        private SQL_CON sqlConn;

        public updateStock_StockKeeper()
        {
            InitializeComponent();
            sqlConn = new SQL_CON();
            button2.Enabled = false;
        }

        private void updateStock_StockKeeper_Load(object sender, EventArgs e)
        {
            foreach (Material material in Program.Materials)
            {
                dataGridView1.Rows.Add(material.Id, material.amount);
                comboBox1.DataSource = Program.Materials;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Material selectedMaterial = comboBox1.SelectedItem as Material;
            if (selectedMaterial == null)
            {
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal amountToAdd))
            {
                return;
            }

            SQL_CON sqlConn = new SQL_CON();
            SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[AddToMaterialAmount] @ID, @amountToAdd", sqlConn.getConnection());
            
                cmd.SelectCommand.Parameters.AddWithValue("@ID", selectedMaterial.Id);
                cmd.SelectCommand.Parameters.AddWithValue("@amountToAdd", amountToAdd);

                sqlConn.Execute_non_query(cmd);
            

            selectedMaterial.amount += amountToAdd;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                if (!(Program.IsValidNumbers(textBox1.Text)))
                    button2.Enabled = false;
                else
                    button2.Enabled = true;
            }
            else
                button2.Enabled = false;
        }
    }
}
