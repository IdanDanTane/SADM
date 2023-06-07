using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_2
{
    public partial class manageProducts : Form
    {
        public manageProducts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createProduct product = new createProduct();
            product.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewProducts products = new viewProducts();
            products.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchProduct product = new searchProduct();
            product.Show();
            this.Hide();

        }
    }
}
