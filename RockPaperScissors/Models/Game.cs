using System.Collections.Generic;
using System;

namespace Play.Models
{
  public static class Game
  {
    public static List <Player> players = new List <Player> () {};

    public static void AddPlayer(string choice)
    {
      Player newPlayer = new Player(choice, false);
      players.Add(newPlayer);
    }

    public static List<Player> GetPlayers()
    {
      return players;
    }

    public static void AddComputer()
    {
      string computerChoice = ComputerChoice();
      Player newPlayer = new Player(computerChoice, true);
      players.Add(newPlayer);
    }

    public static string ComputerChoice()
  {
    string [] allOptions = {"rock", "paper", "scissors"};
    Random rand = new Random();
    int index = rand.Next(allOptions.Length);
    string result = allOptions[index];
    return result;
  }    

    public static string ComparePlayers(Player p1, Player p2)
    {
      if (p1.Property == p2.Property)
      {
        return "Draw";
      }
      else if ( p1.Property == "rock" && p2.Property == "scissors" || p1.Property == "paper" && p2.Property == "rock" || p1.Property == "scissors" && p2.Property == "paper")
      {
        if (p1.Computer == true)
        {
          return "Computer Wins";
        }
        return $"Player {p1.Number} Wins";
      }
      else
      {
        if (p2.Computer == true)
        {
          return "Computer Wins";
        }
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

    public static void ClearAll()
    {
      players.Clear();
    }
  }
}