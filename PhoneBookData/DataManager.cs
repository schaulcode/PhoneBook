using Newtonsoft.Json;
using PhoneBookData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;

namespace PhoneBookData
{
    public static class DataManager
    {
       
        public static List<Entry> GetData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("http://www.mocky.io/v2/581335f71000004204abaf83");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonString = result.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    List<Entry> entries = JsonConvert.DeserializeObject<EntryJson>(jsonString.Result).Entry;
                    return entries;
                }
                return null;
            }
            
        }
    }
}
