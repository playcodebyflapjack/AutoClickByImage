using System;

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
