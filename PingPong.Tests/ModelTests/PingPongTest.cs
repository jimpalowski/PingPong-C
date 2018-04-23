using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;

namespace PingPong.Tests
{

  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivisibleBy3_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(9));
      Console.WriteLine("Ping-Pong");
    }
  }
}
