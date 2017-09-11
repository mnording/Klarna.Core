﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class OrderLine
    {
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
        public int TotalAmount { get; set; }
        [JsonProperty(PropertyName = "total_discount_amount")]
        public int TotalDiscountAmount { get; set; }
        [JsonProperty(PropertyName = "total_tax_amount")]
        public int TotalTaxAmount { get; set; }
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
