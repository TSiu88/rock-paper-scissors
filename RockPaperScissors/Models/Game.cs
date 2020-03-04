using System.Collections.Generic;


namespace Play.Models
{
  public static class Game
  {
    public List <Player> players;
    public bool hasComputerPlayer;

    public Game()
    {
      players = new List <Player> () {};
      hasComputerPlayer = false;
    }

    public void AddPlayer(string choice)
    {
      Player newPlayer = new Player();
      newPlayer.Property = choice;
      players.Add(newPlayer);
    }

    public List<Player> GetPlayers()
    {
      return players;
    }

    private string ComparePlayers(Player p1, Player p2)
    {
      if (p1.Property == p2.Property)
      {
        return "Draw";
      }
      else if ( p1.Property == "rock" && p2.Property == "scissors" || p1.Property == "paper" && p2.Property == "rock" || p1.Property == "scissors" && p2.Property == "paper")
      {
        return "Win";
      }
      else
      {
        return "Lose";
      }
    }

    public string ShowResult()
    {
      for(int i =0; i < players.Count -1; i++)
      {
        Player p1 = players[i];
        for (int j=1; j < players.Count; j++)
        {
          Player p2 = players[j];
          string result = ComparePlayers(p1, p2);
          AddResults(p1, p2, result);
        }
      }
    }

    private void AddResults(Player first, Player second, string result)
    {
      
    }
  }
}