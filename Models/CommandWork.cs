using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace TerminalInfo.Models
{
    public class CommandWork<TResponse,URequest> : ICommandWork<TResponse, URequest> where TResponse : class where URequest : class
    {
       



        public TResponse GetResultCommand(string requestUrl,string requestMethod, URequest PostOrPutRequest)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
            request.Method = requestMethod;
           
            if (request.Method.ToUpper() == "POST" || request.Method.ToUpper() == "PUT" )
            {
                request.Accept = "text/plain";
                request.ContentType = "application/json";
                
                string data = JsonConvert.SerializeObject(PostOrPutRequest);
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(data);
                request.ContentLength = byte1.Length;
                
                Stream newStream = request.GetRequestStream();
                newStream.Write(byte1, 0, byte1.Length);
               
                newStream.Close();

            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        result = reader.ReadToEnd();

                    }
                    response.Close();
                    TResponse GetData = JsonConvert.DeserializeObject<TResponse>(result);
                    return GetData;
                }
            }
            catch (Exception)
            {

                return null;
            }
            
            
            return null;
        }
    }
}
