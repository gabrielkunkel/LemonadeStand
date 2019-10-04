using System.Collections.Generic;
using System.Linq;

namespace LemonadeStand
{
  public class CashRegister
  {
    public double registerAmount = 20;
    public double runningProfit = 0;
    public List<double> dailySalesRecord = new List<double>();
    public List<double> dailyProfitRecord = new List<double>();
    public List<double> dailyExpenseRecord = new List<double>();

    public void DebitRegisterAndCollectExpenses(double debit)
    {
      this.dailyExpenseRecord.Add(debit);
      this.registerAmount -= debit;
    }

    public void Income(double income)
    {
      this.registerAmount += income;
    }

    // todo: write tests for IsThereEnough
    public bool IsThereEnough(double testAmount)
    {
      return testAmount <= registerAmount;
    }

    public double getProfit()
    {
      return registerAmount - 20;
    }

    public void collectDaySalesAndProfit(double todaySales)
    {
      this.dailySalesRecord.Add(todaySales);
    }

    // todo: write test for determineTodayNetProfit
    public void determineTodayNetProfit(double todaySales)
    {
      double todayNetProfit = dailySalesRecord.LastOrDefault() - dailyExpenseRecord.LastOrDefault();
      this.dailyProfitRecord.Add(todayNetProfit);
    }

    // todo: write test for getTodayNetProfit
    public double getTodayNetProfit()
    {
      return this.dailyProfitRecord.LastOrDefault();
    }

  }
}
