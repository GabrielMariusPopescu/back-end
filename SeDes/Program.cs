using Newtonsoft.Json;
using System;

namespace SeDes
{
    public static class Program
    {
        private static Rocket[] Rockets { get; set; }

        private static string RocketsJson { get; set; }

        private static void Main()
        {
            DoSerialization();
            Console.WriteLine("==================================");
            DoDeserialization();
        }

        // Serialize a Rocket array to JSON string
        private static void DoSerialization()
        {
            Rockets = new[]
            {
                new Rocket { Id = 0, Builder = "NASA", Target = "Moon", Speed = 7.8 },
                new Rocket { Id = 1, Builder = "NASA", Target = "Mars", Speed = 10.9 },
                new Rocket { Id = 2, Builder = "NASA", Target = "Kepler-452b", Speed = 42.1 },
                new Rocket { Id = 3, Builder = "NASA", Target = "N/A", Speed = 0 },
            };

            RocketsJson = JsonConvert.SerializeObject(Rockets);
            Console.WriteLine(RocketsJson);
        }

        // Deserialize a JSON string back to a Rocket array
        private static void DoDeserialization()
        {
            var rockets = JsonConvert.DeserializeObject<Rocket[]>(RocketsJson);
            foreach (var rocket in rockets)
            {
                Console.WriteLine($"Id:\t\t{rocket.Id}");
                Console.WriteLine($"Builder:\t{rocket.Builder}");
                Console.WriteLine($"Target:\t\t{rocket.Target}");
                Console.WriteLine($"Speed:\t\t{rocket.Speed}");
            }
        }
    }
}