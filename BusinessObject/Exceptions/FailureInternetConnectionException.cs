using System;

namespace BusinessObject.Exceptions
{
    public class FailureInternetConnectionException : ApplicationException
    {
        public FailureInternetConnectionException() { }

        public FailureInternetConnectionException(string mensagem) : base(mensagem) { }
    }
}
