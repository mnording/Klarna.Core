using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klarna.Entities;

namespace Klarna.Exception
{
    public class ConnectionException : System.Exception
    {
        public ConnectionException(string message, MerchantConfig config, System.Exception inner = null)
            : base(
                message + " Config = username: " + config.merchantId + " and server was " +
                (config.Server == Server.Live ? "Live" : "Playground"), inner)
        { }
        public ConnectionException(string message, System.Exception inner = null) : base(message,inner)
        { }
    }
}
