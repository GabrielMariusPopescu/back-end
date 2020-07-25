using System;
using Newtonsoft.Json;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product{
                Id = 101,
                Name = "Red Apple",
                Price = 1.99
            };

            //Serialize the product object to JSON string
            var jsonString = JsonConvert.SerializeObject(product1);
            Console.WriteLine(jsonString);
            
            //Deserialize the JSON string back to the product object
            var product2 = JsonConvert.DeserializeObject<Product>(jsonString);
            Console.WriteLine($"The product id is\t{product2.Id}");
            Console.WriteLine($"The product name is\t{product2.Name}");
            Console.WriteLine($"The product price is\t{product2.Price}");
        }
    }

    // Create model class

    class Product{
public int Id {get; set;}
public string Name {get; set;}
public double Price {get; set;}
    }
}
