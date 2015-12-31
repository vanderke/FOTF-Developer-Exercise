using System;
using System.IO;
using Website101.Data;
using Website101.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Website101.Tests {
  [TestClass]
  public class DataTests {

    [TestMethod]
    public void TestDataStore() {
      // If you get a InvalidDirectoryException:
      // see Website101.Infrastructure.PathProviders
      string filepath = ServerAccess.MapPath( "~/DataStore/Test.json" );

      // Test if data file exists. (it should not)
      bool exists = File.Exists( filepath );
      Assert.IsFalse( exists, "Setup is clean." );

      DataStore dataStore = new DataStore( filepath );

      Assert.AreEqual( 0, dataStore.Count, "Count is 0 before write." );

      // Test Writing.
      TestNode node = new TestNode( dataStore );
      node.TestString = "This is a test";
      dataStore.ReadFromDataNode( -1, node );
      Assert.AreEqual( 1, dataStore.Count, "Count is 1 after write." );
      dataStore.Save();
      exists = File.Exists( filepath );
      Assert.IsTrue( exists, "Data successfully written." );

      // Test reading.
      DataStore newStore = new DataStore( filepath );
      TestNode newNode = newStore.GetNode<TestNode>( 0 );
      Assert.AreEqual( "This is a test", newNode.TestString, "String read test." );
      Assert.AreEqual( false, newNode.TestBool, "Bool read test." );
      Assert.AreEqual( 0, newNode.TestInt, "Int read test." );
      Assert.AreEqual( null, newNode.TestNullable, "Nullable read test." );

      // Test Deleting.
      newStore.Delete();
      Assert.AreEqual( 0, newStore.Count, "Count is 0 after delete." );
      Assert.IsFalse( File.Exists( filepath ), "File was deleted." );
    }
  }

  /// <summary>
  /// Test the DataNode type with a contrived object.
  /// </summary>
  public class TestNode : DataNode {
    public TestNode( DataStore dataStore, int index = -1 )
      : base( dataStore, index ) {

    }
    public string TestString { get; set; }
    public bool TestBool { get; set; }
    public int TestInt { get; set; }
    public int? TestNullable { get; set; }
  }

  /// <summary>
  /// Test the TestArray<T> type with a contrived object.
  /// </summary>
  public class TestArray<T> : DataArray<T> where T : TestNode {
    protected override string DataName {
      get {
        return "Test";
      }
    }
  }
}
