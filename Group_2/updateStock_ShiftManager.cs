using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_2
{
    public partial class updateStock_ShiftManager : Form
    {
        private SQL_CON sqlConn;

        public updateStock_ShiftManager()
        {
            InitializeComponent();
            sqlConn = new SQL_CON();
            comboBox1.DataSource = Program.Materials;
        }

        private void updateStock_ShiftManager_Load(object sender, EventArgs e)
        {
            foreach (Material m in Program.Materials)
            {
                dataGridView1.Rows.Add(m.Id, m.amount);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Material selectedMaterial = comboBox1.SelectedItem as Material;
            if (selectedMaterial == null)
            {
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal amountToWithdraw))
            {
                return;
            }

            SQL_CON sqlConn = new SQL_CON();
            SqlDataAdapter cmd = new SqlDataAdapter("EXECUTE [dbo].[WithrawalFromMaterialAmount] @ID, @amountToWithdrawal", sqlConn.getConnection());
            
                cmd.SelectCommand.Parameters.AddWithValue("@ID", selectedMaterial.Id);
                cmd.SelectCommand.Parameters.AddWithValue("@amountToWithdrawal", amountToWithdraw);

                sqlConn.Execute_non_query(cmd);
            

            selectedMaterial.amount -= amountToWithdraw;
        }

    private void button1_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }
    }
}
