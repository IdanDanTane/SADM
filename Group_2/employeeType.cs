using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2
{
    public enum employeeType
    {
        [Description("CEO")] CEO,
        [Description("Shift manager")] Shift_manager,
        [Description("Food technologist")] Food_technologist,
        [Description("Stock keeper")]  Stock_keeper,
        [Description("Warehouse manager")] Ware_house_manager
    }
}
