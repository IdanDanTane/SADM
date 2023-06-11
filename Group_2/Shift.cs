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

        public Shift(int SN, DateTime time, bool isNew)
        {
            this.serialNumber = SN;
            this.time = time;
            if (isNew)
            {
                Program.Shifts.Add(this);
            }

        }

        public void createFault( MachineType Mtype, FaultType Ftype, Urgency urgancy, FaultStatus Fstatus)
        {
            Fault f = new Fault(Mtype, Ftype, urgancy, Fstatus, true);
        }
        public void createReport(string shiftID)
        {
            ShiftReport sr = new ShiftReport(shiftID, true);
        }
    }
    
   
}
