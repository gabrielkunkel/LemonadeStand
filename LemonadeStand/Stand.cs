using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class Stand
  {
    public Inventory inventory;
    public CashRegister register;
    public Recipe recipe;
    public LemonadeSupply supplyOfLemonade;

    public Stand()
    {
      this.inventory = new Inventory();
      this.register = new CashRegister();
      this.recipe = new Recipe();
      this.supplyOfLemonade = new LemonadeSupply();
    }

  }
}
