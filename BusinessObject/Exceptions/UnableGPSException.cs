using System;

namespace BusinessObject.Exceptions
{
    public class UnableGPSException : ApplicationException
    {
        public UnableGPSException() { }

        public UnableGPSException(string mensagem) : base(mensagem) { }
    }
}
