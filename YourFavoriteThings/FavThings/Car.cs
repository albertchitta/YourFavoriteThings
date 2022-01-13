using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavThings
{
    class Car
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }

        public void DriveCar()
        {
            Console.WriteLine($"I drive the {Year} {Make} {Model}.");
        }

        public void ImportCar()
        {
            Console.WriteLine($"It was imported from {Country}.");
        }
    }
}
