using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Debugging_And_Exception_Handling.CustomExceptions
{
	public class RemoveCarException : Exception
	{
        public RemoveCarException()
        {
        }

        public RemoveCarException(string message) : base(message) 
        {
        }

        public RemoveCarException(string message, Exception innerException) : base(message, innerException)
        {    
        }
    }
}
