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
    public partial class Create_fault : Form
    {
        public Create_fault()
        {
            InitializeComponent();
            MTypeCh.DataSource = Enum.GetValues(typeof(MachineType));
            FTypeCh.DataSource = Enum.GetValues(typeof(FaultType));
            UtypeCh.DataSource = Enum.GetValues(typeof(Urgency));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MTypeCh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FTypeCh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fault f = new Fault((MachineType)Enum.Parse(typeof(MachineType), this.MTypeCh.Text.Replace(' ', '_')), (FaultType)Enum.Parse(typeof(FaultType), this.FTypeCh.Text.Replace(' ', '_')), (Urgency)Enum.Parse(typeof(Urgency), this.UtypeCh.Text.Replace(' ', '_')),FaultStatus.Decommissioned,true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
