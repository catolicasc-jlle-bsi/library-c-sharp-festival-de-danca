using System;

namespace BusinessObject.Exceptions
{
    public class AuthenticationFailureException : ApplicationException
    {
        public AuthenticationFailureException() { }

        public AuthenticationFailureException(string mensagem) : base(mensagem) { }
    }
}
