using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
    public void Return3()
    {
      //Eventual Tests
      Leet leet = new Leet();
      Assert.AreEqual("3", leet.ConvertLeet("e"));
    }
    [TestMethod]
    public void Return0()
    {
      //Eventual Tests
      Leet leet = new Leet();
      Assert.AreEqual("0", leet.ConvertLeet("o"));
    }
    [TestMethod]
    public void Return1()
    {
      //Eventual Tests
      Leet leet = new Leet();
      Assert.AreEqual("1", leet.ConvertLeet("i"));
    }
    [TestMethod]
    public void Return7()
    {
      //Eventual Tests
      Leet leet = new Leet();
      Assert.AreEqual("7", leet.ConvertLeet("t"));
    }
    [TestMethod]
    public void Returnz()
    {
      //Eventual Tests
      Leet leet = new Leet();
      Assert.AreEqual("sz", leet.ConvertLeet("ss"));
    }
  }
}
