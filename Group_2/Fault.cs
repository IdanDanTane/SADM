using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    public class Fault
    {
        public int id;
        public MachineType Mtype;
        public FaultType Ftype;
        public Urgency urgancy;
        public FaultStatus Fstatus;
        public static int SerialNum=1;


       public Fault( MachineType Mtype, FaultType Ftype, Urgency urgancy, FaultStatus Fstatus,bool isNew)
        {
            this.id = Fault.SerialNum;
            this.Mtype = Mtype;
            this.Ftype = Ftype;
            this.urgancy = urgancy;
            this.Fstatus = Fstatus;
            Fault.SerialNum++;
            if (isNew)
            {
                this.createFault();
                Program.Faults.Add(this);
            }
        }

        private void createFault()
        {

            SQL_CON SC = new SQL_CON();
            SqlDataAdapter r = new SqlDataAdapter("EXECUTE [dbo].[AddFault] @faultID, @machineType, @faultType ,@Urgency , @faultStatus ", SC.getConnection());
            r.SelectCommand.Parameters.AddWithValue("@faultID", this.id);
            r.SelectCommand.Parameters.AddWithValue("@machineType", this.Mtype.ToString());
            r.SelectCommand.Parameters.AddWithValue("@faultType", this.Ftype.ToString());
            r.SelectCommand.Parameters.AddWithValue("@Urgency", this.urgancy.ToString());
            r.SelectCommand.Parameters.AddWithValue("@faultStatus", this.Fstatus.ToString());
            SC.Execute_non_query(r);
        }
    }

    }

