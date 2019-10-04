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

    // todo: create validation class

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

    public void EndDay()
    {
      // todo: how much we've made today
      // todo: total profit or loss in the game so far
    }

    public void GetInventoryUpdate(Stand stand)
    {
      bool stayOnInventoryUpdate = false;

      do
      {
        Messages.PrintCurrentInventory(stand);
        Messages.PrintEmptyLine();
        Messages.PromptForInventory();
        int lemons = Convert.ToInt32(Console.ReadLine());
        int sugarCubes = Convert.ToInt32(Console.ReadLine());
        int iceCubes = Convert.ToInt32(Console.ReadLine());
        int cups = Convert.ToInt32(Console.ReadLine());
        Messages.PrintEmptyLine();

        double totalCost = stand.inventory.GetTotalCost(sugarCubes, lemons, iceCubes, cups);
        if (stand.register.IsThereEnough(totalCost))
        {
          stand.register.DebitRegister(totalCost);
          stand.inventory.AddToInventory(sugarCubes, lemons, iceCubes, cups);
          stayOnInventoryUpdate = false;
        }
        else
        {
          Messages.PrintNotEnoughMoney(stand.register);
          stayOnInventoryUpdate = true;
        } 
      } while (stayOnInventoryUpdate);
     
    }

    public void SoldOutOfInventory(Stand stand)
    {
      Messages.PrintEmptyLine();
      Messages.PrintOutOfInventory();
      Messages.PrintEmptyLine();
      Messages.PrintCurrentInventory(stand);
      Messages.PrintEmptyLine();
    }

    public void GetRecipeUpdate(Stand stand)
    {
      bool stayOnRecipeUpdate = false;

      do
      {
        Messages.PrintEmptyLine();
        Messages.PrintCurrentRecipe(stand.recipe);
        Messages.PromptForRecipe();
        stand.recipe.lemonsPerCup = Convert.ToDouble(Console.ReadLine());
        stand.recipe.sugarCubesPerCup = Convert.ToDouble(Console.ReadLine());
        stand.recipe.iceCubesPerCup = Convert.ToDouble(Console.ReadLine());
        stand.recipe.price = Convert.ToDouble(Console.ReadLine());
        Messages.PrintEmptyLine();
        Messages.PrintRecipeUpdated();
        Messages.PrintCurrentRecipe(stand.recipe);

      } while (stayOnRecipeUpdate);

    }

    public void GameAllOver()
    {
      Messages.PrintGameOver();
    }

  }
}
