using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand;

namespace LemonadeStandConsole
{
  public class Messages
  {

    public static void Introduction()
    {
      Console.WriteLine("Welcome to Lenmonade Stand!");
    }

    public static void PromptForInventory()
    {
      Console.WriteLine("What do you want to buy? Lemons, Sugar Cubes, Ice Cubes, Cups");
    }

    public static void PrintCurrentInventory(Player player)
    {
      Console.WriteLine("Your current inventory is:");
      Console.WriteLine($"You have {player.stand.inventory.lemons.quantity} lemons.");
      Console.WriteLine($"You have {player.stand.inventory.sugarCubes.quantity} sugar cubes.");
      Console.WriteLine($"You have {player.stand.inventory.iceCubes.quantity} ice cubes.");
      Console.WriteLine($"You have {player.stand.inventory.cups.quantity} cups.");
    }

    public static void PromptForRecipe()
    {
      Console.WriteLine("What do you want the current recipe to be?");
    }

    public static void PrintDay(int dayNumber)
    {
      Console.WriteLine($"The current day: {dayNumber}");
    }

    public static void PrintEmptyLine()
    {
      Console.WriteLine("                    ");
    }

    public static void PrintGameOver()
    {
      Console.WriteLine("The Game is Over. Goodbye.");
    }

  }
}
