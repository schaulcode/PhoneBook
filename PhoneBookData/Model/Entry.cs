using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookData.Model
{
    public class EntryJson
    {
        [JsonProperty("contacts")]
        public List<Entry> Entry { get; set; }
    }
    public class Entry
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
