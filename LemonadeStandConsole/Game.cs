using LemonadeStandConsole;
using LemonadeStand;

namespace LemonadeStand
{
  public class Game
  {
    public Player player;
    public int totalDays;
    public Day currentDay;
    public int dayNumber = 0;
    public UIProvider uIProvider;

    public Game(UIProvider uIProvider)
    {
      this.totalDays = 7;
      this.player = new Player();
      this.uIProvider = uIProvider;
    }

    public Game(UIProvider uIProvider, int totalDays)
    {
      this.totalDays = totalDays;
      this.player = new Player();
      this.uIProvider = uIProvider;
    }

    public void RunGameLoop()
    {
      uIProvider.Start();
      do
      {
        dayNumber += 1;
        this.currentDay = new Day(uIProvider, dayNumber);
        currentDay.Run(this.player);
      } while (ContinueGame());
      uIProvider.GameAllOver();

    }

    private bool ContinueGame()
    {
      return dayNumber < totalDays;
    }



  }
}
