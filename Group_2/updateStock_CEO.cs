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
    public partial class updateStock_CEO : Form
    {
        public updateStock_CEO()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateStock_ShiftManager updateStockShiftManagerForm = new updateStock_ShiftManager();
            updateStockShiftManagerForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateStock_StockKeeper updateStockStockKeeperForm = new updateStock_StockKeeper();
            updateStockStockKeeperForm.Show();
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
