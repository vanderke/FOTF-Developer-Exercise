using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Website101.Data {
  public class DataStore : IDataStore {

    /// <summary>
    /// The location of the json file.
    /// </summary>
    private string _filepath;

    /// <summary>
    /// The json data object.
    /// </summary>
    private JArray _data;

    /// <summary>
    /// The number of objects in the data store.
    /// </summary>
    public int Count {
      get {
        return _data.Count;
      }
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="filepath">The location of the data file.</param>
    public DataStore( string filepath ) {
      _filepath = filepath;
      this.Load();
    }

    /// <summary>
    /// Load json data from filesystem.
    /// </summary>
    public void Load() {
      if ( File.Exists( _filepath ) ) {
        string json = File.ReadAllText( _filepath );
        _data = JArray.Parse( json );
      }
      else {
        _data = new JArray();
      }
    }

    /// <summary>
    /// Save json data to the filesystem.
    /// </summary>
    public void Save() {
      File.WriteAllText( _filepath, _data.ToString() );
    }

    /// <summary>
    /// Remove data from datasource.
    /// </summary>
    public void Delete() {
      _data.RemoveAll();
      File.Delete( _filepath );
    }

    /// <summary>
    /// Remove an entry.
    /// </summary>
    /// <param name="index">The index of the entry</param>
    public void Remove( int index ) {
      _data.RemoveAt( index );
      this.Save();
    }

    /// <summary>
    /// Get a data node.
    /// </summary>
    /// <typeparam name="T">IDataNode</typeparam>
    /// <param name="index">The index to retrieve the node from.</param>
    /// <returns></returns>
    public T GetNode<T>( int index = -1 ) where T : IDataNode {
      object[] args = new object[2] {
        this,
        index
      };
      return (T)Activator.CreateInstance( typeof( T ), args );
    }

    /// <summary>
    /// Write json data to the DataNode object.
    /// </summary>
    /// <param name="index">The index of the data to write from.</param>
    /// <param name="node">An IDataNode object.</param>
    public void WriteToDataNode( int index, IDataNode node ) {
      JToken data = _data.ElementAt( index );
      if ( index < 0 || data == null ) {
        throw new IndexOutOfRangeException();
      }
      PropertyInfo[] properties = node.GetType().GetProperties();
      foreach ( PropertyInfo property in properties ) {
        object value = data[property.Name];
        value = Convert.ChangeType( value, property.PropertyType );
        property.SetValue( node, value );
      }
    }

    /// <summary>
    /// Read json data from the DataNode object.
    /// </summary>
    /// <param name="index">The index of the data to read to.</param>
    /// <param name="node">An IDataNode object.</param>
    public void ReadFromDataNode( int index, IDataNode node ) {
      string nodeJson = new JavaScriptSerializer().Serialize( node );
      JObject obj = JObject.Parse( nodeJson );
      if ( node.IsNew() ) {
        // Add new node.
        _data.Add( obj );
      }
      else {
        // Update existing.
        _data[index] = obj;
      }
    }

    /// <summary>
    /// Give access to the JArray object.
    /// </summary>
    /// <returns>JArray object.</returns>
    public JArray ToJArray() {
      return _data;
    }
  }
}