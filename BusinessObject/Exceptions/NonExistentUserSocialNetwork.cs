using System;

namespace BusinessObject.Exceptions
{
    public class NonExistentUserSocialNetwork : ApplicationException
    {
        public NonExistentUserSocialNetwork() { }

        public NonExistentUserSocialNetwork(string mensagem) : base(mensagem) { }
    }
}
