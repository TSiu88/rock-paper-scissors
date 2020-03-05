using System;

namespace Play.Models
{
  public class Player
  {
    public string Property { get; set; }
    public int Number { get; set; }
    private static int _currentNumber = 1;
    public bool Computer { get; set; }

    public Player(string property, bool isComputer)
    {
      Property = property; 
      Number = GetCurrentNumber();
      Computer = isComputer;
    }  

    private static int GetCurrentNumber()
    {
      return _currentNumber++;
    }

    public static void ClearAll()
    {
      _currentNumber = 1;
    }
  }

}
