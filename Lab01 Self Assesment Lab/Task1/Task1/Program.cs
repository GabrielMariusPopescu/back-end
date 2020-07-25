using System;
using Newtonsoft.Json;

namespace Task1
{
    public static class Program
    {
        private static void Main()
        {
            Task1();
        }

        //

        private static void Task1()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Computer keyboard",
                Price = 28.99
            };

            var json = JsonConvert.SerializeObject(product);
            Console.WriteLine(json);

            var product2 = JsonConvert.DeserializeObject<Product>(json);
            Console.WriteLine($"Product id is\t{product2.Id}");
            Console.WriteLine($"Product name is\t{product2.Name}");
            Console.WriteLine($"Product price is\t{product2.Price}");

            Console.ReadLine();
        }
    }
}
