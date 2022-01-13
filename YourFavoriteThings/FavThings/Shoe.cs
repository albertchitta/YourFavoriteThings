using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavThings
{
    class Shoe
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void BuyShoe()
        {
            Console.WriteLine($"I am buying the {Color} {Brand} {Model}.");
        }

        public void WearShoe()
        {
            Console.WriteLine($"I wear them more for style than running.");
        }
    }
}
