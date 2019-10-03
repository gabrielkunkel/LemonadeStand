using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  interface IRequestMaker
  {

    Recipe currentRecipe {get; set;}
    Inventory currentInventory {get; set;}
    void SetRecipe(Recipe recipe);
    void SetInventory(Inventory inventory);

    


  }
}
