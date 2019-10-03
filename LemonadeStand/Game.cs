namespace LemonadeStand
{
  public class Game
  {
    Player player;
    int totalDays;
    Day currentDay;
    int dayNumber;

    public Game()
    {
      this.totalDays = 7;
      this.player = new Player();
    }

    public Game(int totalDays)
    {
      this.totalDays = totalDays;
      this.player = new Player();
    }

    public void RunGameLoop()
    {
      do
      {
        dayNumber += 1;
        currentDay = new Day();
        currentDay.Run(this.player);
      } while (ContinueGame());

    }

    private bool ContinueGame()
    {
      return dayNumber <= totalDays;
    }



  }
}
