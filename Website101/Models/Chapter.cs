using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website101.Data;

namespace Website101.Models {
  public class Chapter : DataNode {
    public Chapter( int index, DataStore dataSource )
      : base( index, dataSource ) {

    }

    public int Number { get; set; }

    public string Title { get; set; }

    public string Summary { get; set; }
  }
}