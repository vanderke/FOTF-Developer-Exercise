using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyToWed.IO
{
    public interface IFileReader
    {
        Task<Maybe<string>> ReadAsync(string fileName);
    }
}
