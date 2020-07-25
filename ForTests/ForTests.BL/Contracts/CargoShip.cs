using ForTests.BL.Ships;

namespace ForTests.BL.Contracts
{
  public class CargoShip : ISpaceShips
  {
    public bool LoadCargo()
    {
      Armor = 100;
      SetFuel(1000);
      isLoaded = GetFuel() > 100;
      return isLoaded;
    }

    public int GetFuel() => Fuel;

    public void SetFuel(int sFuel) => Fuel = sFuel;

    public State GetState() => State;

    public void SetState(State sState) => State = sState;

    public int LaserHit() => Armor;

    //
    private int Fuel { get; set; }
    private bool isLoaded;
    private State State { get; set; }
    private int Armor { get; set; }
  }
}
