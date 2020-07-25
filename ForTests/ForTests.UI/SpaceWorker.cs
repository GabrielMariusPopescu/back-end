using ForTests.BL;
using ForTests.BL.Contracts;
using ForTests.BL.Ships;
using System;

namespace ForTests.UI
{
  internal class SpaceWorker
  {

    internal string GetSpaceshipInfo()
    {
      var combatShip = new CombatShip();
      combatShip.SetFuel(10);
      combatShip.SetState(State.Battle);

      var spaceshipFuel = combatShip.GetFuel();
      var spaceshipState = combatShip.GetState();
      return message + $"{combatShip.GetType().Name} fuel:\t{spaceshipFuel}{Environment.NewLine}state: {spaceshipState}" + Environment.NewLine;
    }

    internal string GetCargoShipInfo()
    {
      var cargoShip = new CargoShip();
      var cargoStatus = cargoShip.LoadCargo();
      var remainingFuel = cargoShip.GetFuel();

      return message + $"{cargoShip.GetType().Name} fuel:\t{remainingFuel}{Environment.NewLine}Is it loaded? {cargoStatus}" + Environment.NewLine;
    }

    internal string GetDamageInfo()
    {
      var cargoShip = new CargoShip();
      var combatShip = new CombatShip();

      armor = combatShip.LaserHit().ToString();

      return message + $"{cargoShip.GetType().Name}\tarmor: {cargoShip.LaserHit()}{Environment.NewLine}" +
        $"{combatShip.GetType().Name}\tarmor: {armor}{Environment.NewLine}";
    }

    private readonly string message = "=========================" + Environment.NewLine;
    private string armor = "";
  }
}