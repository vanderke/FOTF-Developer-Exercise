using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website101.Data {
  abstract public class DataNode : IDataNode {

    protected int _index = -1;

    protected IDataStore _data;

    public bool IsNew() {
      return _index < 0;
    }

    public DataNode() { }

    public DataNode( IDataStore dataStore, int index = -1 ) {
      _data = dataStore;
      _index = index;
      this.Load();
    }

    /// <summary>
    /// Load data from the data store.
    /// </summary>
    public virtual void Load() {
      if ( !this.IsNew() ) {
        _data.WriteToDataNode( _index, this );
      }
    }

    /// <summary>
    /// Save data to the data store.
    /// </summary>
    public virtual void Save() {
      _data.ReadFromDataNode( _index, this );
      _data.Save();
    }

    /// <summary>
    /// Remove this data from the data store.
    /// </summary>
    public virtual void Remove() {
      if ( !this.IsNew() ) {
        _data.Remove( _index );
        _index = -1;
      }
    }

    /// <summary>
    /// Get the current index.
    /// </summary>
    /// <returns>The index of this node.</returns>
    public int GetIndex() {
      return _index;
    }

    /// <summary>
    /// Update the index.
    /// </summary>
    /// <param name="index">The index of the node.</param>
    public void SetIndex( int index ) {
      _index = index;
    }
  }
}