using Newtonsoft.Json;

namespace Klarna.Entities.Attachement
{
    public class Person
    {
        [JsonProperty(PropertyName = "id")]
        public int Id;
        [JsonProperty(PropertyName = "title")]
        public string Title;
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName;
        [JsonProperty(PropertyName = "last_name")]
        public string LastName;
    }
}
