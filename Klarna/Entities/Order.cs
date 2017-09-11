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
        [JsonProperty(PropertyName = "order_lines")]
        protected List<OrderLine> cart;
        MerchantConfig _config;
        [JsonProperty(PropertyName = "shipping_address")]
        public  Address ShippingAddress;
        [JsonProperty(PropertyName = "billing_address")]
        public Address BillingAddress;
        [JsonProperty(PropertyName = "merchant_urls")]
        public MerchantUrls Merchanturls;

        public Order(List<OrderLine> cart,MerchantUrls urls)
        {
            this.cart = cart;
            Merchanturls = urls;
        }
        public Order(List<OrderLine> cart, MerchantUrls urls, Address shippAddress,  Address billAddress = null):this(cart,urls)
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
