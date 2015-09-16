using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website101.Data {
  public class JsonEnumerator<T> : IEnumerator<T> where T : IDataNode {

    private DataStore _data;
    private int _index = -1;

    public JsonEnumerator( DataStore data ){
      _data = data;
    }

    #region IEnumerator<T> Members

    /// <summary>
    /// Implement IEnumerator.Current
    /// Return the object at the current index.
    /// </summary>
    object IEnumerator.Current {
      get {
        return Current;
      }
    }

    /// <summary>
    /// Implement IEnumerator<T>.Current
    /// Return the object at the current index.
    /// </summary>
    public T Current {
      get {
        if ( _index < 0 ) {
          throw new InvalidOperationException();
        }
        if ( _index >= _data.Count ) {
          throw new InvalidOperationException();
        }
        return _data.GetNode<T>( _index );
      }
    }


    /// <summary>
    /// Implement IEnumerator<T>.Reset
    /// Reset the index back to start.
    /// </summary>
    public void Reset() {
      _index = -1;
    }

    /// <summary>
    /// Implement IEnumerator<T>.MoveNext
    /// Increment the index.
    /// </summary>
    public bool MoveNext() {
      _index++;
      if ( _index >= _data.Count ) {
        return false;
      }
      return true;
    }

    /// <summary>
    /// Implementing IDesposable.Dispose
    /// Cleanup unmanaged resources.
    /// </summary>
    public void Dispose() {
      // This class only holds a reference to it's resources.
    }

    #endregion
  }
}