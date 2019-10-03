namespace LemonadeStand
{
  public class Player
  {
    public string name;
    public Stand stand;

    public Player()
    {
      this.stand = new Stand();
      this.name = "The Great Lemonade Stand";
    }

  }
}