using System;
using System.IO;

namespace ForTests.UI
{
  internal static class Program
  {
    private static void Main()
    {
      //Ships();
      //Machines();
      Others();
      Console.ReadLine();
    }

    private static void Ships()
    {
      Console.WriteLine("=========================");
      Console.WriteLine("= Work with space ships =");
      Console.WriteLine("=========================");

      var spaceWorker = new SpaceWorker();
      Console.WriteLine(spaceWorker.GetSpaceshipInfo());
      Console.WriteLine(spaceWorker.GetCargoShipInfo());
      Console.WriteLine(spaceWorker.GetDamageInfo());
    }

    private static void Machines()
    {
      Console.WriteLine("==================================");
      Console.WriteLine("= Work with other machines ships =");
      Console.WriteLine("==================================");
      var worker = new Worker();
      Console.WriteLine(worker.GetPlaneInfo());
      Console.WriteLine(worker.GetCarInfo());
    }

    private static void Others()
    {
      Stream s = new MemoryStream();
      Console.WriteLine($"Start: {DateTime.Now.ToLocalTime().Millisecond}");
      s.WriteByte(200);
      Console.WriteLine($"Write stream: {DateTime.Now.ToLocalTime().Millisecond}\t{s.ReadByte()}");
      s.Flush();
      Console.WriteLine($"Flush stream: {DateTime.Now.ToLocalTime().Millisecond}\t{s.ReadByte()}");
    }
  }
}
