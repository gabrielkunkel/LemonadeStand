﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  class CupStore : ItemStore
  {
    public CupStore(string name, double cost)
    {
      this.name = name;
      this.cost = cost;
    }
  }
}
