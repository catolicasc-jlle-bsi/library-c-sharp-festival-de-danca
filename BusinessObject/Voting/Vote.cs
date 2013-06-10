using System;

namespace BusinessObject.Voting
{
    /// <summary>
    /// Determina a nota de 0 a 5
    /// </summary>
    public enum Rating
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
    }

    /// <summary>
    /// Representa um voto
    /// </summary>
    public class Vote
    {
        public Vote()
        {
            this.Token = Guid.NewGuid();
            this.Date = DateTime.Now;
            this.Grade = Rating.Zero;
        }

        /// <summary>
        /// Nota
        /// </summary>
        public Rating Grade { get; set; }

        /// <summary>
        /// Data da votação
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Token gerado pelo cliente
        /// </summary>
        public Guid Token { get; private set; }

        /// <summary>
        /// Determina a apresentação
        /// </summary>
        public Apresentation Apresentation { get; set; }
    }
}
