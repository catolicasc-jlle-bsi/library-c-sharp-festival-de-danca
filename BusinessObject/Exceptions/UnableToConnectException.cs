using System;

namespace BusinessObject.Exceptions
{
    public class UnableToConnectException : ApplicationException
    {
        public UnableToConnectException() { }

        public UnableToConnectException(string mensagem) : base(mensagem) { }
    }
}
