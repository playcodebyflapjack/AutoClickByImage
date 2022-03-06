using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickByImage.exception
{
    class OpenCvException : Exception
    {
        public OpenCvException()
        {
        }

        public OpenCvException(string message, Exception exception)
            : base(message, exception)
        {

        }

    }
}
