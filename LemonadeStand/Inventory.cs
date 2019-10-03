namespace LemonadeStand
{
  public class Inventory
  {
    public ItemStore lemons;
    public ItemStore iceCubes;
    public ItemStore cups;
    public ItemStore sugarCubes;

    public Inventory()
    {
      this.lemons = new ItemStore("lemons", 0.60);
      this.iceCubes = new ItemStore("ice cubes", 0.05);
      this.cups = new ItemStore("cups", 0.10);
      this.sugarCubes = new ItemStore("sugar cubes", 0.15);
    }

    // todo: check that there is enough inventory to make a cup of lemonade with current recipe (Recipe recipe)

  }
}