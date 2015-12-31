using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website101.Data {
  public interface IDataStore {

    /// <summary>
    /// Load data from datasource.
    /// </summary>
    void Load();

    /// <summary>
    /// Sync data to the datasource.
    /// </summary>
    void Save();

    /// <summary>
    /// Remove data from datasource.
    /// </summary>
    void Delete();

    /// <summary>
    /// Remove an entry.
    /// </summary>
    /// <param name="index">The index of the entry</param>
    void Remove( int index );

    /// <summary>
    /// Get a data node of type IDataNode.
    /// </summary>
    /// <typeparam name="T">IDataNode</typeparam>
    /// <param name="index">The index to retrieve the node from.</param>
    /// <returns>IDataNode object.</returns>
    T GetNode<T>( int index = -1 ) where T : IDataNode;

    /// <summary>
    /// Write data to the IDataNode object.
    /// </summary>
    /// <param name="index">The index of the data to write from.</param>
    /// <param name="node">An IDataNode object.</param>
    void WriteToDataNode( int index, IDataNode node );

    /// <summary>
    /// Read data from the DataNode object.
    /// </summary>
    /// <param name="index">The index of the data to write node data to.</param>
    /// <param name="node">An IDataNode object.</param>
    void ReadFromDataNode( int index, IDataNode node );
  }
}
