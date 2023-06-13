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
    public partial class ProductionFormForCEO : Form
    {
        public ProductionFormForCEO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductionForm productionForm = new ProductionForm();
            productionForm.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductionFormForShift productionForm = new ProductionFormForShift();
            productionForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homepage homepageForm = new homepage();
            homepageForm.Show();
            this.Hide();
        }
    }
}
