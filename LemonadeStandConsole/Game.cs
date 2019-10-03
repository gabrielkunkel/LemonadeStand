using LemonadeStandConsole;
using LemonadeStand;

namespace LemonadeStand
{
  public class Game
  {
    public Player player;
    public int totalDays;
    public Day currentDay;
    public int dayNumber;
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
        uIProvider.GetInventoryUpdate(this.player);
        this.currentDay = new Day(uIProvider);
        currentDay.Run(this.player);
      } while (ContinueGame());

    }

    private bool ContinueGame()
    {
      return dayNumber <= totalDays;
    }



  }
}
