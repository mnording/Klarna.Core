using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class OrderLine
    {
        private int? _totaltaxamount;
        private int? _totalamount;
        private int? _totaldiscountamount;
        [JsonProperty(PropertyName = "image_url")]
        public Uri ImageUrl { get; set; }
        [JsonProperty(PropertyName = "merchant_data")]
        public string MerchantData { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "product_url")]
        public Uri ProductUrl { get; set; }
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }
        [JsonProperty(PropertyName = "quantity_unit")]
        public string QuantityUnit { get; set; }
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }
        [JsonProperty(PropertyName = "tax_rate")]
        public int TaxRate { get; set; }
        [JsonProperty(PropertyName = "total_amount")]
        public int? TotalAmount {
            get { return _totalamount; }
            set
            {
                if (value != null)
                {
                    _totalamount = (int)value;
                    return;
                }
                else
                {
                    _totalamount = null;
                    return;
                }
            }
        }
        [JsonProperty(PropertyName = "total_discount_amount")]
        public int? TotalDiscountAmount {
            get { return _totaldiscountamount; }
            set
            {
                if (value != null)
                {
                    _totaldiscountamount = (int)value;
                    return;
                }
                else
                {
                    _totaldiscountamount = null;
                    return;
                }
            }
        }
        [JsonProperty(PropertyName = "total_tax_amount")]
        public int? TotalTaxAmount {
            get { return _totaltaxamount; }
            set
            {
                if (value != null)
                {
                    _totaltaxamount = (int) value;
                    return;
                }
                else
                {
                    _totaltaxamount = null;
                    return;
                }
            } }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "unit_price")]
        public int UnitPrice { get; set; }

        public OrderLine(string name, int quantity, int unit_price,int tax_rate)
        {
            if (tax_rate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tax_rate),"Tax Rate must be => 0");
            }
            if (name == "")
            {
                throw new ArgumentException("Name cannot be empty",nameof(name));
            }
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be => 0");
            }
            Name = name;
            Quantity = quantity;
            UnitPrice = unit_price;
            TotalAmount = UnitPrice*Quantity;
            TaxRate = tax_rate;
            TotalTaxAmount = CalculateTaxAmountFromGross();
        }

        public OrderLine(string name,string reference, int quantity, int unit_price, int tax_rate):this(name,quantity,unit_price,tax_rate)
        {
            Reference = reference;
        }

        private int CalculateTaxAmountFromGross()
        {
            double taxratefordivide = TaxRate / 10000.00;
            var priceexvat = TotalAmount / (1 + (taxratefordivide));
            priceexvat = priceexvat - TotalAmount;
            priceexvat = priceexvat * -1;
            return (int)(priceexvat);
        }
    }
}
