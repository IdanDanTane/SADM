using System;
using System.Linq;
using System.Windows.Forms;

namespace Group_2
{
    public partial class updateStock_StockKeeper : Form
    {
        public updateStock_StockKeeper()
        {
            InitializeComponent();
        }

        private void updateStock_StockKeeper_Load(object sender, EventArgs e)
        {
            foreach (Material material in Program.Materials)
            {
                dataGridView1.Rows.Add(material.Id, material.amount);
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
                // Show an error message or handle the case where no material is selected
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal amountToAdd))
            {
                // Show an error message or handle the case where an invalid amount is entered
                return;
            }

            selectedMaterial.amount += amountToAdd;
        }
    }
}