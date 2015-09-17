using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Website101.Data {
  public interface IDataNode {

    /// <summary>
    /// Test if the node has not been inserted.
    /// </summary>
    bool IsNew();

    /// <summary>
    /// Load data from the data store.
    /// </summary>
    void Load();

    /// <summary>
    /// Save data to the data store.
    /// </summary>
    void Save();

    /// <summary>
    /// Remove this data from the data store.
    /// </summary>
    void Remove();

    /// <summary>
    /// Get the current index.
    /// </summary>
    /// <returns>The index of this node.</returns>
    int GetIndex();

    /// <summary>
    /// Update the index.
    /// </summary>
    /// <param name="index">The index of the node.</param>
    void SetIndex( int index );
  }
}
