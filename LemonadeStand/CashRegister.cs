namespace LemonadeStand
{
  public class CashRegister
  {
    public double registerAmount = 20;

    public void DebitRegister(double debit)
    {
      this.registerAmount -= debit;
    }

    public void Income(double income)
    {
      this.registerAmount += income;
    }

    // todo: test this
    public bool IsThereEnough(double testAmount)
    {
      return testAmount <= registerAmount;
    }

  }
}
