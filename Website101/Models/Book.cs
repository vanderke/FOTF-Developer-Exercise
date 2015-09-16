using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website101.Data;

namespace Website101.Models {
  public class Book<T> : DataArray<T> where T : Chapter {

    protected override string DataName {
      get {
        return "Book";
      }
    }

    public string Title {
      get {
        return "Ready To Wed";
      }
    }

    public T GetChapter( int number ) {
      return this.Where( t => t.Number == number ) as T;
    }
  }
}