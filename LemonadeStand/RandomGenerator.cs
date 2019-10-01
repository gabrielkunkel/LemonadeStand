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

    



  }
}
