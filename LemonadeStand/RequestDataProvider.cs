using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  class RequestDataProvider
  {
    IRequestMaker requestMade;

    public RequestDataProvider(IRequestMaker requestMade)
    {
      this.requestMade = requestMade;
    }

    public void RequestRecipe(Recipe recipe)
    {
      requestMade.SetRecipe(recipe);
    }

    public void RequestInventory(Inventory inventory)
    {
      requestMade.SetInventory(inventory);
    }

  }
}
