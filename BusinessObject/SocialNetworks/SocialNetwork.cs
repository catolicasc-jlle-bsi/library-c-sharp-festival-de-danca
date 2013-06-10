using System;
using System.Collections.Generic;

namespace BusinessObject.SocialNetworks
{
    /// <summary>
    /// Redes sociais disponíveis no aplicativo
    /// </summary>
    public enum SocialNetworkAvailable
    {
        Facebook,
        Twitter,
    }

    /// <summary>
    /// Representa uma rede social
    /// </summary>
    public class SocialNetwork
    {
        public SocialNetwork(SocialNetworkAvailable socialNetWork)
        {
            this.SocialNetworkAvailable = socialNetWork;
        }

        public SocialNetworkAvailable SocialNetworkAvailable { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }//TODO
    }
}
