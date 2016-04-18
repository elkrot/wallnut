using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Utils
{
    public static class Settings
    {
        public static short DepartmentWorkshopId { get { return 2; } }

        public static short LocationWorkshopId { get { return 2; } }
        public static short LocationStorehouseId { get { return 1; } } 

        public static int DefaultShiftId { get { return 1; }  }
        

        public static int IntaktNutId { get {return 1;} } // Целый орех
        public static int WalnutKernelId { get { return 5; }  }// Ядро
        public static int ShucksId { get { return 6; }  } // Скорлупа
        
        
        
    }
}
