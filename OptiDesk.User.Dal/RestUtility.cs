using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OptiDesk.User.Dal
{
    public static class RestUtility
    {
        public static T Fetch<T>(string url)
        {
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";

                response = (HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
                string json = sr.ReadToEnd();

                T res = JsonConvert.DeserializeObject<T>(json);

                return res;
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;
                    Console.Write("Errorcode: {0}", (int)response.StatusCode);
                }
                else
                {
                    Console.Write("Error: {0}", e.Status);
                }

                throw new Exception("Err in call API " + url);
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
        }

        public static void Send<T>(string url, Verb verb, T data)
        {
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

                string json = JsonConvert.SerializeObject(data);

                request.Method = verb.ToString();
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = json.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(Encoding.UTF8.GetBytes(json), 0, json.Length);
                }

                response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (WebException e)
            {
                throw new Exception("Err in call API " + url);
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
        }
    }
}
