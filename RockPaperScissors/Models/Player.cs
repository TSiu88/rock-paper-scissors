using System;

namespace Play.Models
{
  public class Player
  {
    public string Property { get; set; }
    public int Number { get; set; }
    private static int _currentNumber = 1;

    public Player(string property)
    {
      Property = property; 
      Number = GetCurrentNumber();
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
