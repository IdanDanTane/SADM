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
        public static int serialNum = 1;

        public Shift(DateTime time, bool isNew)
        {
            this.serialNumber = serialNum;
            this.time = time;
            serialNum++;
            if (isNew)
            {
                Program.Shifts.Add(this);
            }

        }

        public void createFault( MachineType Mtype, FaultType Ftype, Urgency urgancy, FaultStatus Fstatus)
        {
            Fault f = new Fault(Mtype, Ftype, urgancy, Fstatus, true);
        }
        public void createReport()
        {
            ShiftReport sr = new ShiftReport(this.serialNumber, true);
        }
    }
    
   
}
