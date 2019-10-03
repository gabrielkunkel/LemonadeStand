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

    public void StartDay(int dayNumber)
    {
      Messages.PrintDay(dayNumber);
    }

    public void 

    public void GetInventoryUpdate(Player player)
    {
      Messages.PrintCurrentInventory(player);
      Messages.PrintEmptyLine();
      Messages.PromptForInventory();
      player.stand.inventory.lemons.quantity += Convert.ToInt32(Console.ReadLine());
      player.stand.inventory.sugarCubes.quantity += Convert.ToInt32(Console.ReadLine());
      player.stand.inventory.iceCubes.quantity += Convert.ToInt32(Console.ReadLine());
      player.stand.inventory.cups.quantity += Convert.ToInt32(Console.ReadLine());
    }

    public void GameAllOver()
    {
      Messages.PrintGameOver();
    }

  }
}
