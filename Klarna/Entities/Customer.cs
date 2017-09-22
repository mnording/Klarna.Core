using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class Customer
    {
        [JsonProperty(PropertyName = "type")]
        public string Type;
        [JsonProperty(PropertyName = "date_of_birth")]
        public DateTime DateOfBirth;
        [JsonProperty(PropertyName = "gender")]
        public string Gender;

        public int Age
        {
            get
            {
                DateTime zeroTime = new DateTime(1, 1, 1);
                var time = DateTime.Now - DateOfBirth;
                int years = (zeroTime + time).Year - 1;
                return years;
            }
        }



    }
}
