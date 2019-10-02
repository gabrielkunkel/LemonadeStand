using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  class Stand
  {

    public Inventory inventory;
    public CashRegister register;
    public Recipe recipe;
    public ProductSupply supplyOfLemonade;

    public Stand()
    {
      this.inventory = new Inventory();
      this.register = new CashRegister();
      this.recipe = new Recipe();
      this.supplyOfLemonade = new ProductSupply();
  }

  }
}
