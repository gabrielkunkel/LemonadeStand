using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class Wallet
  {
    double walletAmount = 20;

    public void ReduceWallet(double debit)
    {
      this.walletAmount -= debit;
    }

    public void Income(double income)
    {
      this.walletAmount += income;
    }

  }
}
