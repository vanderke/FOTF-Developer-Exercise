using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website101.Data;

namespace Website101.Models {
  public class Chapter : DataNode {
    public Chapter( DataStore dataSource, int index = -1 )
      : base( dataSource, index ) {

    }

    public Chapter() : base() {
      _data = new Book<Chapter>().GetDataStore();
    }

    public int Number { get; set; }

    public string Title { get; set; }

    public string Summary { get; set; }

    public override void Save() {
      this._FixIndex();
      base.Save();
    }

    private void _FixIndex() {
      foreach ( Chapter chapter in new Book<Chapter>() ) {
        if ( chapter.Number == Number ) {
          _index = chapter.GetIndex();
          return;
        }
      }
      _index = -1;
    }
  }
}