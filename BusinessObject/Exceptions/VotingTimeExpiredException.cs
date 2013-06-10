using System;

namespace BusinessObject.Exceptions
{
    public class VotingTimeExpiredException : ApplicationException
    {
        public VotingTimeExpiredException() { }

        public VotingTimeExpiredException(string mensagem) : base(mensagem) { }
    }
}
