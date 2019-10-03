using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class ItemStore
  {
    public double cost;
    public string name;
    public int quantity;

    public ItemStore(string name, double cost)
    {
      this.cost = cost;
      this.name = name;
      this.quantity = 0;
    }

    public void IncrceaseQuantity(int amount)
    {
      if (amount > 0)
      {
        this.quantity += amount;
      }
    }

    public void UseItem(int amount)
    {
      if (amount > 0)
      {
        this.quantity -= amount;
      }
    }


  }



}
