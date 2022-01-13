using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavThings
{
    class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }

        public void WatchMovie()
        {
            Console.WriteLine($"Let's watch {Title} with {Actor}.");
        }

        public void ShowDirector()
        {
            Console.WriteLine($"It is directed by {Director}.");
        }
    }
}
