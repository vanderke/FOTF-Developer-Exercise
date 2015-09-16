using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Website101.Data {
  public interface IDataNode {

    void Load();

    void Save();
  }
}
