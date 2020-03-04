namespace Play.Models
{
  class Player
  {
    public string Property { get; set; }
    public int Number { get; set; }
    private static int _currentNumber = 0;

    Player(string property)
    {
      Property = property; 
      Number = GetCurrentNumber();
    }  

    private static int GetCurrentNumber()
    {
      return _currentNumber++;
    }
  }

}
