using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyToWed.Data
{
    public interface IModelReader
    {
        Task<Maybe<T>> ReadAsync<T>(int id) where T : Models.Model;
    }
}
