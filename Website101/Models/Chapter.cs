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

    public int Number { get; set; }

    public string Title { get; set; }

    public string Summary { get; set; }
  }
}