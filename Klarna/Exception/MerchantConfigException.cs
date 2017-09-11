namespace Klarna.Exception
{
    public class MerchantConfigException:System.Exception
    {
        public MerchantConfigException(string message,System.Exception inner = null) : base(message,inner)
        { }
    }
}
