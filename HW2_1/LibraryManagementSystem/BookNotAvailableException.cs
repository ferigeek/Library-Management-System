using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookNotAvailableException : Exception
    {
        public string Message { get; set; }

        public BookNotAvailableException(string message) : base(message)
        {
            Message = message;
        }
    }
}
