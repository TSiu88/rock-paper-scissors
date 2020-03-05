using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Play.Models;

namespace Play.Test
{
  [TestClass]
  public class GameTests : IDisposable
  {
    public void Dispose()
    {
      Player.ClearAll();
      Game.ClearAll();
    }

    [TestMethod]
    public void AddPlayer_PlayerAddedToList_ListOfPlayers()
    {
      Game.AddPlayer("rock");
      Game.AddPlayer("paper");
      int result = Game.players.Count;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void AddComputer_ComputerAddedToList_ListOfPlayers()
    {
      Game.AddPlayer("rock");
      Game.AddComputer();
      int result = Game.players.Count;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ComputerChoice_ChoiceContainedInOptions_OptionChosen()
    {
      string [] allOptions = {"rock", "paper", "scissors"};
      string result = Game.ComputerChoice();
      CollectionAssert.Contains(allOptions, result);
    }

    [TestMethod]
    public void ComparePlayers_FindWinner_Player2Wins()
    {
      Player p1 = new Player("rock",false);
      Player p2 = new Player("paper",false);
      string result = Game.ComparePlayers(p1, p2);
      Assert.AreEqual("Player 2 Wins", result);
    }

    [TestMethod]
    public void ComparePlayers_FindWinner_Player1Wins()
    {
      Player p1 = new Player("scissors",false);
      Player p2 = new Player("paper",false);
      string result = Game.ComparePlayers(p1, p2);
      Assert.AreEqual("Player 1 Wins", result);
    }

    [TestMethod]
    public void ShowResult_LoopsWork_ResultPrints()
    {
      Game.AddPlayer("rock");
      Game.AddPlayer("paper");
      string result = Game.ShowResult();
      Assert.AreEqual("Player 2 Wins", result);
    }
  }
}