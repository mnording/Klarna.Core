using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klarna.Helpers
{
   public class DigestCreator
    {
        [Obsolete("Deprecated method use CreateDigest() instead")]
        public string CreateOffline(string merchantId,string sharedSecret)
        {
            return CreateDigest(merchantId, sharedSecret);
        }
        public string CreateDigest(string merchantId, string sharedSecret)
        {
            byte[] authBytes = Encoding.UTF8.GetBytes(merchantId + ":" + sharedSecret);
            var digest = Convert.ToBase64String(authBytes);
            return digest;
        }
    }
}
