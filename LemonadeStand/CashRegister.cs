namespace LemonadeStand
{
  public class CashRegister
  {
    double registerAmount = 20;

    public void DebitRegister(double debit)
    {
      this.registerAmount -= debit;
    }

    public void Income(double income)
    {
      this.registerAmount += income;
    }

  }
}
