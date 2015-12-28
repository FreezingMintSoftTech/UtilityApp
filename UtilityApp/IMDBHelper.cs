using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UtilityApp
{
    class IMDBHelper
    {
        public string GetIMDBLinkByTitle(string title)
        { 
            string link= string.Empty;

            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://www.imdb.com/xml/find?json=1&nr=1&tt=on&q=$q");
            Uri uri = new Uri("http://www.imdb.com/xml/find?json=1&nr=1&tt=on&q='" + title+"'");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(uri).Result;

            if (response.IsSuccessStatusCode)
            {
                //string yourcustomobjects = response.Content.ToString();//.ReadAsAsync<IEnumerable<YourCustomObject>>().Result;
                string json = response.Content.ReadAsStringAsync().Result;
  
                JsonTextReader reader = new JsonTextReader(new StringReader(json));
                while (reader.Read())
                {
                   if (reader.Value != null)
                   {
                       if (reader.Value.Equals("id"))
                       {
                           reader.Read();//next value
                           link = "http://www.imdb.com/title/" + reader.Value;
                           break;
                       }
                   }
                        //Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                   else
                        Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
            else
            {
                //Something has gone wrong, handle it here
            }
            //"http://www.imdb.com/xml/find?json=1&nr=1&tt=on&q=$q");
            return link;
        }
    }
}
