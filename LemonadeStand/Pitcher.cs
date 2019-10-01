using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class Pitcher
  {
    public int cupsLeftInPitcher;

    public Pitcher(int cupsOfLemonade)
    {
      this.cupsLeftInPitcher = cupsOfLemonade;
    }

    public void AddMultipleCups(int cupsAdding)
    {
      this.cupsLeftInPitcher += cupsAdding;
    }

    public void SubtractMultipleCups(int cupsDebiting)
    {
      this.cupsLeftInPitcher -= cupsDebiting;
    }

  }
}
