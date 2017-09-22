using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class Order
    {
        MerchantConfig _config;
        [JsonProperty(PropertyName = "shipping_address")]
        public  Address ShippingAddress;
        [JsonProperty(PropertyName = "billing_address")]
        public Address BillingAddress;
        [JsonProperty(PropertyName = "merchant_urls")]
        public MerchantUrls Merchanturls;
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer;

        public Order(MerchantUrls urls)
        {
            
            Merchanturls = urls;
        }
        public Order(MerchantUrls urls, Address shippAddress,  Address billAddress = null):this(urls)
        {
            ShippingAddress = shippAddress;
            BillingAddress = billAddress;
            if (billAddress == null)
            {
                BillingAddress = ShippingAddress;
            }
        }
    }

}
