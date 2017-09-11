using System;
using System.IO;
using System.Net;
using Klarna.Exception;

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
            catch (System.Exception e)
            {
                throw new ConnectionException(e.Message);
            }
            
        }
    }
}
