using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Utils
{
    public static class Settings
    {
        public static short WorkshopId { get { return 2; } } 
        public static int DefaultShiftId { get { return 1; }  }
        public enum WallnutState
        {
            IntaktNut=1, WalnutKernel=2, Shucks=3
        }
    }
}
