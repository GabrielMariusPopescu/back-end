namespace ForTests.BL.Ships
{
  public interface ISpaceShips
  {
    int GetFuel();

    void SetFuel(int sFuel);

    State GetState();

    void SetState(State sState);

    int LaserHit();
  }
}
