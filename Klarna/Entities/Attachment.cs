using Klarna.Entities.Attachement;
using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class Attachment
    {
        [JsonProperty(PropertyName = "body")]
        public AttacementBody Body;
        [JsonProperty(PropertyName = "content_type")]
        public string ContentType { get;  }
        public Attachment()
        {
            ContentType = "application/vnd.klarna.internal.emd-v2+json";
            Body= new AttacementBody();
        }
    }
}
