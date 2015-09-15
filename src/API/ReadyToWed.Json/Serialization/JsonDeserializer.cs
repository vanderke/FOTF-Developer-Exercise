using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyToWed.Serialization
{
    public class JsonDeserializer : IDeserializer
    {
        public async Task<T> DeserializeObjectAsync<T>(string value)
        {
            T obj = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value));
            return obj;
        }
    }
}
