using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Utils
{
    public class OperationResults
    {
        public bool Success { get; set; }
        public List<string> MessageList { get; private set; }

    public OperationResults(){
        MessageList = new List<string>();
        Success = true;
    }

    public void AddMessage(string message) {
        MessageList.Add(message);
    }
    }
}
