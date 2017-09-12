using System;
using System.IO;
using System.Net;
using Klarna.Exception;
using Newtonsoft.Json;

namespace Klarna.Helpers
{
    public class JsonRequest
    {
       public HttpWebResponse CreateRequest(string digest,Uri url, string method, string body = null,string useragent ="Mnording SDK")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = method;
            request.ContentType = "application/json";
            request.UserAgent = useragent;
            request.Headers.Add("Authorization", "Basic " + digest);
            if (body != null)
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(body);
                }
            }
            try
            {
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                return response;
            }
            catch (WebException ex)
            {
                var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                ApiException obj = JsonConvert.DeserializeObject<ApiException>(resp);
                throw obj;
            }
            
        }
    }
}
