using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand;

namespace LemonadeStandConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      UIProvider myUIProvider = new UIProvider();
      Game myGame = new Game(myUIProvider);
      myGame.RunGameLoop();
      myUIProvider.GameAllOver();

    }
  }
}
