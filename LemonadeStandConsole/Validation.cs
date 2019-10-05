using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LemonadeStandConsole
{
  public static class Validation
  {

    // todo: write test for GetData with Moq
    public static string GetData(string infoRequested, Regex regex)
    {
      Match stillLoop;
      string input;

      do
      {
        Console.WriteLine(infoRequested);
        input = Console.ReadLine();
        stillLoop = regex.Match(input);

        if (!stillLoop.Success)
        {
          PrintErrorMessage(regex);
        }

      } while (!stillLoop.Success);

      return input;
    }


    private static void PrintErrorMessage(Regex regex)
    {

      if (regex.Match("89").Success)
      {
        Console.WriteLine("This field only accepts numbers. Try again.");
      }
      else if (regex.Match("yes").Success)
      {
        Console.WriteLine("This field only accepts a *yes* or *no*. Try again.");
      }
      else if (regex.Match("abcdefghi").Success)
      {
        Console.WriteLine("This field only accepts letters. Try again.");
      }
      else
      {
        Console.WriteLine("That is invalid input. Try again.");
      } 

    }

  }

}
