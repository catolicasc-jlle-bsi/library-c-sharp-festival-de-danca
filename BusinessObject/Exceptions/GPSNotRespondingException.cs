using System;

namespace BusinessObject.Exceptions
{
    public class GPSNotRespondingException : ApplicationException
    {
        public GPSNotRespondingException() { }

        public GPSNotRespondingException(string mensagem) : base(mensagem) { }
    }
}
