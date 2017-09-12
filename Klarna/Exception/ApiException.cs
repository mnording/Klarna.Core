using System;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Klarna.Exception
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiException:WebException
    {
        [JsonProperty(PropertyName = "correlation_id")]
        public string correlation_id;
        [JsonProperty(PropertyName = "error_code")]
        public string error_code;
        [JsonProperty(PropertyName = "error_messages")]
        public string[] error_messages;
        [JsonProperty(PropertyName = "error_text")]
        public string[] error_text;
        public string ErrorMessage;
        public ApiException(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
                this.ErrorMessage = info.GetString("ErrorMessage");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
                info.AddValue("ErrorMessage", this.ErrorMessage);
        }
    }
}
