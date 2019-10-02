using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  class IceCubeStore : ItemStore
  {

    public IceCubeStore(string name, double cost)
    {
      this.name = name;
      this.cost = cost;
    }

  }
}
