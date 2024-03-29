﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LemonadeStand;

namespace LemonadeStandConsole
{
  public class UIProvider
  {
    private string regexDecimalNumbersString = @"^-?\d*(\.\d+)?$";
    private string regexYesOrNo = @"(\byes\b)|(\bno\b)";

    public UIProvider()
    {
    }

    public void Start()
    {
      Messages.Introduction();
    }

    public void StartDay(int dayNumber, Weather today, Weather forecast)
    {
      Messages.PrintStartOfDayHeader(dayNumber);
      Messages.PrintDayStats(dayNumber, today, forecast);
      Messages.PrintEmptyLine();
    } 

    public void EndDay(Player player)
    {
      Messages.PrintTotalProfit(player.stand.register);
      Messages.PrintRegisterAmount(player.stand.register);
      Messages.PrintTodayProfit(player.stand.register);
    }

    // todo: shorten GetInventoryUpdate
    public void GetInventoryUpdate(Stand stand)
    {
      bool stayOnInventoryUpdate = false;
      Messages.PrintInventoryHeader();
      Messages.PrintCurrentInventory(stand);
      Messages.PrintEmptyLine();
      Messages.PrintCashRegisterTotal(stand);
      Messages.PrintEmptyLine();

      string yesOrNo = Validation.GetData("Do you want to purchase lemonade ingredients or cups? (yes/no)", new Regex(regexYesOrNo));
      if (yesOrNo == "yes")
      {
        stayOnInventoryUpdate = true;
      }

      while (stayOnInventoryUpdate)
      {
        Messages.PromptForInventory(stand);
        double lemons = Convert.ToDouble(Validation.GetData("How many LEMONS do you want to buy?", new Regex(regexDecimalNumbersString)));
        double sugarCubes = Convert.ToDouble(Validation.GetData("How many SUGAR CUBES do you want to buy?", new Regex(regexDecimalNumbersString)));
        double iceCubes = Convert.ToDouble(Validation.GetData("How many ICE CUBES do you want to buy?", new Regex(regexDecimalNumbersString)));
        double cups = Convert.ToDouble(Validation.GetData("How many CUPS do you want to buy?", new Regex(regexDecimalNumbersString)));
        Messages.PrintEmptyLine();

        // todo: move expense logic to CashRegister or Day
        double totalCost = stand.inventory.GetTotalCost(sugarCubes, lemons, iceCubes, cups);
        if (stand.register.IsThereEnough(totalCost))
        {
          stand.register.DebitRegisterAndCollectExpenses(totalCost);
          stand.inventory.AddToInventory(sugarCubes, lemons, iceCubes, cups);
          Messages.PrintEmptyLine();
          Messages.PrintCashRegisterTotal(stand);
          Messages.PrintEmptyLine();
          stayOnInventoryUpdate = false;
        }
        else
        {
          Messages.PrintNotEnoughMoney(stand.register);
          stayOnInventoryUpdate = true;
        } 
      }
    }

    public void SoldOutOfInventory(Stand stand)
    {
      Messages.PrintEmptyLine();
      Messages.PrintDashedLine();
      Messages.PrintOutOfInventory();
      Messages.PrintEmptyLine();
      Messages.PrintCurrentInventory(stand);
      Messages.PrintDashedLine();
      Messages.PrintEmptyLine();
    }

    public void ReportTotalCupsSold(int totalCupsSold)
    {
      Messages.PrintTotalCupsSold(totalCupsSold);
    }

    public void GetRecipeUpdate(Stand stand)
    {
      bool stayOnRecipeUpdate = false;
      Messages.PrintRecipeHeader();
      Messages.PrintEmptyLine();
      Messages.PrintCurrentRecipe(stand.recipe);

      string yesOrNo = Validation.GetData("Do you want to adjust the recipe and/or your price per cup? (yes/no)", new Regex(regexYesOrNo));
      if (yesOrNo == "yes")
      {
        stayOnRecipeUpdate = true;
      }

      while (stayOnRecipeUpdate)
      {
        Messages.PromptForRecipe();
        stand.recipe.lemonsPerCup = Convert.ToDouble(Validation.GetData("How many LEMONS do you want in each cup of lemonade?", new Regex(regexDecimalNumbersString)));
        stand.recipe.sugarCubesPerCup = Convert.ToDouble(Validation.GetData("How many SUGAR CUBES do you want in each cup of lemonade?", new Regex(regexDecimalNumbersString)));
        stand.recipe.iceCubesPerCup = Convert.ToDouble(Validation.GetData("How many ICE CUBES do you want in each cup of lemonade?", new Regex(regexDecimalNumbersString)));
        stand.recipe.price = Convert.ToDouble(Validation.GetData("How much do you want to charge for each cup of lemonade?", new Regex(regexDecimalNumbersString)));
        Messages.PrintEmptyLine();
        Messages.PrintRecipeUpdated();
        Messages.PrintCurrentRecipe(stand.recipe);

        stayOnRecipeUpdate = false;
      } ;
    }

    public void GameAllOver()
    {
      Messages.PrintGameOver();
    }

  }
}
