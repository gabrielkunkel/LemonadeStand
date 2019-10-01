using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class RandomGenerator
  {
    private readonly Random random;


    public RandomGenerator(Random random = default(Random))
    {
      this.random = random ?? new Random(Guid.NewGuid().GetHashCode());
    }

    public string GetRandomListMember(List<string> anyStringList)
    {
      int randomInt = random.Next(anyStringList.Count);
      return anyStringList[randomInt];
    }

    public double GetRandomSpendingMoney(double startAmount)
    {
      double input = random.NextDouble() + startAmount;
      // returns less than one dollar + the starting amount to 2 decimal places
      return Math.Round(input, 2, MidpointRounding.AwayFromZero);
    }

    public List<string> GetDictionaryStringOnProbability(Dictionary<string, double> dictionaryToProcess)
    {
      List<string> listOfAcceptedStrings = new List<string>();
      double comparator;

      foreach (KeyValuePair<string, double> keyValuePair in dictionaryToProcess)
      {
        comparator = random.NextDouble();
        if (comparator < keyValuePair.Value)
        {
          listOfAcceptedStrings.Add(keyValuePair.Key);
        }

      }
      return listOfAcceptedStrings;
    }
    



  }
}
