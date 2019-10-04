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
      Print("Welcome to Lenmonade Stand!");
    }

    public static void PromptForInventory()
    {
      Print("What do you want to buy? Lemons, Sugar Cubes, Ice Cubes, Cups");
    }

    public static void PrintCurrentInventory(Stand stand)
    {
      Print("Your current inventory is:");
      Print($"You have {stand.inventory.lemons.quantity} lemons.");
      Print($"You have {stand.inventory.sugarCubes.quantity} sugar cubes.");
      Print($"You have {stand.inventory.iceCubes.quantity} ice cubes.");
      Print($"You have {stand.inventory.cups.quantity} cups.");
    }

    public static void PrintNotEnoughMoney(CashRegister cashRegister)
    {
      Print("You don't have enough money in your register to buy all that.");
      Print($"Your register only has ${cashRegister.registerAmount}.");
      PrintEmptyLine();
    }

    public static void PrintOutOfInventory()
    {
      Print("You are out of inventory. This means you sold out all the lemonade for today.");
    }

    public static void PrintRecipeUpdated()
    {
      Print("Recipe Updated!");
    }

    public static void PrintCurrentRecipe(Recipe recipe)
    {
      Print("This is your current recipe right now:");
      Print($"{recipe.lemonsPerCup} lemons per cup.");
      Print($"{recipe.sugarCubesPerCup} sugar cubes per cup.");
      Print($"{recipe.iceCubesPerCup} ice cubes per cup.");
      Print($"You're selling these for a price of {recipe.price} per cup.");
    }

    public static void PromptForRecipe()
    {
      Print("What do you want the recipe to be?");
    }

    public static void PrintStartOfDayHeader(int dayNumber)
    {
      Print("=====================================");
      Print($"         DAY {dayNumber}");
      Print("=====================================");
    }

    public static void PrintDayStats(int dayNumber, Weather weather, Weather forecast)
    {
      Print($"The current day: {dayNumber}.");
      Print($"The weather is: {weather.condition}.");
      Print($"The weather tomorrow is supposed to be: {forecast.condition}.");
    }

    public static void PrintTotalProfit(CashRegister cashRegister)
    {
      Print($"Your total profit in the game so far is: ${cashRegister.getProfit()}");
    }

    public static void PrintRegisterAmount(CashRegister cashRegister)
    {
      Print($"The total amount in your register is: ${cashRegister.registerAmount}");
    }

    public static void PrintTodayProfit(CashRegister cashRegister)
    {
      Print($"The total profit for today is: ${cashRegister.getTodayNetProfit()}");
    }

    public static void PrintTotalCupsSold(int totalCupsSold)
    {
      Print($"You've sold {totalCupsSold} today!");
    }

    public static void PrintEmptyLine()
    {
      Print("                    ");
    }

    public static void PrintDashedLine()
    {
      Print("---------------------------");
    }

    public static void PrintGameOver()
    {
      Print("The Game is Over. Goodbye.");
    }

    private static void Print(string stringToPrint)
    {
      Console.WriteLine(stringToPrint);
    }

  }
}
