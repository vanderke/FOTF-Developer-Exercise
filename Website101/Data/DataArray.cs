using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Website101.Infrastructure;

namespace Website101.Data {
  abstract public class DataArray<T> : IEnumerable<T> where T : IDataNode {

    /// <summary>
    ///   The name of the json file. Must be overriden by 
    ///   child class.
    /// </summary>
    protected virtual string DataName { get; }

    /// <summary>
    ///   The name of the directory that json data files
    ///   are stored in.
    /// </summary>
    protected virtual string DataDirectory {
      get {
        return "DataStore";
      }
    }

    /// <summary>
    /// The data storage for this array.
    /// </summary>
    private DataStore _data;

    /// <summary>
    /// Constructor.
    /// Populate data from the data store.
    /// </summary>
    public DataArray(){
      _data = new DataStore( this.DataLocation() );
      this.Initialize();
    }

    /// <summary>
    /// Allow derived classes to setup.
    /// </summary>
    protected virtual void Initialize() {

    }

    /// <summary>
    ///   Returns the full path the json data file for
    ///   this array.
    /// </summary>
    /// <returns>The path to the data store json file.</returns>
    public string DataLocation() {
      return ServerAccess.MapPath( "~/" + DataDirectory + "/" + DataName + ".json" );
    }

    /// <summary>
    /// Give access to the JArray object.
    /// </summary>
    /// <returns>JArray object.</returns>
    public JArray ToJArray() {
      return _data.ToJArray();
    }

    #region IEnumerable<T> Members

    IEnumerator IEnumerable.GetEnumerator() {
      return this.GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator() {
      return new JsonEnumerator<T>( _data );
    }

    #endregion
  }
}