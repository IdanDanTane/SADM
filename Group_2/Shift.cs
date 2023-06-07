using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    public class Shift
    {
        public int serialNumber;
        public DateTime time;

        public Shift(int SN, DateTime time)
        {
            this.serialNumber = SN;
            this.time = time;
            
        }

        public void createFault(int id, MachineType Mtype, FaultType Ftype, Urgency urgancy, FaultStatus Fstatus)
        {

        }
    }
    
   
}
