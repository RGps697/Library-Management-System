using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class OperationResult
    {
        public bool IsSuccess { get; private set; }
        public string Message { get; private set; }
        
        internal OperationResult(bool success, string message = "")
        {
            IsSuccess = success;
            Message = message;
        }
    }
}
