using System;
using System.Collections.Generic;
using System.Text;

namespace ParsingService.Services.Exceptions
{
    public class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException()
        {
        }

        public InvalidFileTypeException(string message)
            : base(message)
        {
        }

        public InvalidFileTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
