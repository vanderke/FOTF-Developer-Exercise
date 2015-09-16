using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website101.Data {
  abstract public class DataNode : IDataNode {

    protected int _index;

    protected DataStore _data;

    public DataNode( int index, DataStore dataStore ) {
      _index = index;
      _data = dataStore;
      this.Load();
    }

    /// <summary>
    /// Load data from the data store.
    /// </summary>
    public void Load() {
      _data.WriteToDataNode( _index, this );
    }

    /// <summary>
    /// Save data to the data store.
    /// </summary>
    public void Save() {
      _data.ReadFromDataNode( _index, this );
      _data.Save();
    }
  }
}