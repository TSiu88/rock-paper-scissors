using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Play.Models;

namespace Play.Test
{
  [TestClass]
  public class PlayerTests : IDisposable
  {
    public void Dispose()
    {
      Player.ClearAll();
      Game.ClearAll();
    }

    [TestMethod]
    public void GetCurrentNumber_GetPlayerName_PlayerNumber()
    {
      Player p1 = new Player("rock");
      Player p2 = new Player("paper");
      Player p3 = new Player("scissors");
      int result = p3.Number;
      Assert.AreEqual(3, result);
    }
  }
}