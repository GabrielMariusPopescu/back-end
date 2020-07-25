using ForTests.BL;
using System;

namespace ForTests.UI
{
  internal class Worker
  {
    internal string GetPlaneInfo()
    {
      var plane = new Plane
      {
        Fuel = 100,
        State = State.Moving
      };
      return message + $"{plane.GetType().Name} fuel: {plane.Fuel}{Environment.NewLine}state: {plane.State}" + Environment.NewLine;
    }

    internal string GetCarInfo()
    {
      var car = new Car
      {
        Fuel = 150,
        State = State.Moving
      };

      do
      {
        car.Fuel -= 20;
        if (car.Fuel > 100)
          car.State = State.Battle;
        else if (car.Fuel > 0)
          car.State = State.Moving;
        else
          car.State = State.Stopped;
        state += $"{car.GetType().Name} fuel: {car.Fuel}\tstate: {car.State}" + Environment.NewLine;
      } while (car.Fuel > 0);

      return message + state;
    }

    //
    private readonly string message = "==================================" + Environment.NewLine;

    private string state = "";
  }
}
