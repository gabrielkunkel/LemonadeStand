using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand;

namespace LemonadeStandConsole
{
  public class UIProvider
  {

    public UIProvider()
    {
    }

    public void Start()
    {
      Messages.Introduction();
    }

    public void StartDay(int dayNumber, Weather today, Weather forecast)
    {
      Messages.PrintDayStats(dayNumber, today, forecast);
      Messages.PrintEmptyLine();
    } 

    public void GetInventoryUpdate(Player player)
    {
      bool stayOnInventoryUpdate = false;

      do
      {
        Messages.PrintCurrentInventory(player);
        Messages.PrintEmptyLine();
        Messages.PromptForInventory();
        int lemons = Convert.ToInt32(Console.ReadLine());
        int sugarCubes = Convert.ToInt32(Console.ReadLine());
        int iceCubes = Convert.ToInt32(Console.ReadLine());
        int cups = Convert.ToInt32(Console.ReadLine());
        Messages.PrintEmptyLine();

        double totalCost = player.stand.inventory.GetTotalCost(sugarCubes, lemons, iceCubes, cups);
        if (player.stand.register.IsThereEnough(totalCost))
        {
          player.stand.register.DebitRegister(totalCost);
          player.stand.inventory.AddToInventory(sugarCubes, lemons, iceCubes, cups);
          stayOnInventoryUpdate = false;
        }
        else
        {
          Messages.PrintNotEnoughMoney(player.stand.register);
          stayOnInventoryUpdate = true;
        } 
      } while (stayOnInventoryUpdate);
     
    }

    public void GameAllOver()
    {
      Messages.PrintGameOver();
    }

  }
}
