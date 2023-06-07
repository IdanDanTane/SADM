using System;
using System.Collections.Generic;
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

       public Fault(int id, MachineType Mtype, FaultType Ftype, Urgency urgancy, FaultStatus Fstatus)
        {
            this.id = id;
            this.Mtype = Mtype;
            this.Ftype = Ftype;
            this.urgancy = urgancy;
            this.Fstatus = Fstatus;
        }

    }
}
