namespace ForTests.BL.Ships
{
  public class CombatShip : ISpaceShips
  {
    public void Engage() => Armor = 1000;
    public int GetFuel() => Fuel;

    public void SetFuel(int sFuel) => Fuel = sFuel;

    public State GetState() => State;

    public void SetState(State sState) => State = sState;

    public int LaserHit() => Armor;

    //
    private int Fuel { get; set; }
    private State State { get; set; }
    private int Armor { get; set; }
  }
}