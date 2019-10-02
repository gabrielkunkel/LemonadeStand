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

    // todo: public void RunGame

    // todo: days
    // todo: gameLoop
      // increment dayNumber
      // create new day
      // add money to cashRegister




  }
}
