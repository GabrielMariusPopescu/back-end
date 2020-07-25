namespace ForTests.BL
{
  public class Car
  {
    public int Fuel
    {
      get { return fuel; }
      set { fuel = value < 0 ? 0 : value; }
    }

    public State State { get; set; }

    //
    private int fuel;
  }
}
