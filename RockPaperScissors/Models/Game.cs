using System.Collections.Generic;


namespace Play.Models
{
  public static class Game
  {
    public static List <Player> players = new List <Player> () {};

    public static void AddPlayer(string choice)
    {
      Player newPlayer = new Player(choice);
      players.Add(newPlayer);
    }

    public static string ComparePlayers(Player p1, Player p2)
    {
      if (p1.Property == p2.Property)
      {
        return "Draw";
      }
      else if ( p1.Property == "rock" && p2.Property == "scissors" || p1.Property == "paper" && p2.Property == "rock" || p1.Property == "scissors" && p2.Property == "paper")
      {
        return $"Player {p1.Number} Wins";
      }
      else
      {
        return $"Player {p2.Number} Wins";
      }
    }

    public static string ShowResult()
    {
      for(int i =0; i < players.Count -1; i++)
      {
        Player p1 = players[i];
        for (int j=1; j < players.Count; j++)
        {
          Player p2 = players[j];
          string result = ComparePlayers(p1, p2);
          return result;
          //AddResults(p1, p2, result);
        }
      }
      return "error";
    }

    private static void AddResults(Player first, Player second, string result)
    {
      
    }

    public static void ClearAll()
    {
      players.Clear();
    }
  }
}