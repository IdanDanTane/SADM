﻿using System;
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
    public partial class viewMAT : Form
    {
        public viewMAT()
        {
            InitializeComponent();
        }

        private void ViewMAT2_Load(object sender, EventArgs e)
        {
            SQL_CON SC = new SQL_CON();
            DataTable dt = new DataTable();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[ViewMaterial] ", SC.getConnection());
            r.Fill(dt);
            viewMAT2.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageMaterials MAT = new manageMaterials();
            MAT.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
