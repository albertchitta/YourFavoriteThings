using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavThings
{
    class Sport
    {
        public string Name { get; set; }
        public int Players { get; set; }

        public void PlaySport()
        {
            Console.WriteLine($"I love to play {Name}.");
        }

        public void CountPlayers()
        {
            Console.WriteLine($"It consists of {Players} players.");
        }
    }
}
