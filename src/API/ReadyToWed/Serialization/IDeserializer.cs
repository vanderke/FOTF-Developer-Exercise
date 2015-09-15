using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyToWed.Serialization
{
    public interface IDeserializer
    {
        Task<T> DeserializeObjectAsync<T>(string value);
    }
}
