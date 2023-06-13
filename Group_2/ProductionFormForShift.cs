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
    public partial class ProductionFormForShift : Form
    {
        public ProductionRequirement temp;
        public ProductionFormForShift()
        {
            InitializeComponent();
            os.DataSource = Enum.GetValues(typeof(OrderStatus));
            this.crDate.Enabled = false;
            this.trDate.Enabled = false;
            this.pr.Enabled = false;
            this.os.Enabled = false;
            this.comboBox1.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
           }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.seekProduction(textBox1.Text.ToString()) == null)
            {
                MessageBox.Show("This Production Requirement does not exist. please try again");
            }
            else { 
                temp = Program.seekProduction(textBox1.Text);
                this.crDate.Value = temp.createDate;
                this.trDate.Value = temp.targetDate;
                this.pr.AppendText(temp.price.ToString()) ;
                this.os.SelectedItem = temp.status;
                this.comboBox1.Enabled = true;
                foreach (Product p in temp.toProduce.Keys)
                {
                    dataGridView1.Rows.Add(p.Id, temp.toProduce[p]);
                }
                comboBox1.DataSource = temp.toProduce.Keys.ToList();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (Material m in Program.seekProduct(comboBox1.Text.ToString()).componenets.Keys)
            {
                dataGridView2.Rows.Add(m.Id, Program.seekProduct(comboBox1.Text.ToString()).componenets[m] * temp.toProduce[Program.seekProduct(comboBox1.Text.ToString())]);
            }
        }

        private void pr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
