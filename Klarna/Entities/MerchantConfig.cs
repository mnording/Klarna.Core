using Klarna.Exception;

namespace Klarna.Entities
{
    public class MerchantConfig
    {
        public string merchantId;
        public string sharedSecret;
        public Server Server;

        public MerchantConfig(string merchant, string password, Server server)
        {
            if(merchant == null)
                throw new MerchantConfigException("MerchantConfig must to be a string");
            merchantId = merchant;
            if(password == null)
                throw new MerchantConfigException("MerchantConfig must to be a string");
            sharedSecret = password;
           
            Server = server;
        }
    }
    public enum Server { Playground, Live }
}
