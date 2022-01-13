
using YourFavoriteThings.FavThings;
using System;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Make = "Nissan",
                Model = "R34 GT-R",
                Year = 2002,
                Country = "Japan",
            };
            Car car2 = new Car
            {
                Make = "Toyota",
                Model = "Supra",
                Year = 1993,
                Country = "Japan",
            };

            Sport sport = new Sport
            {
                Name = "Volleyball",
                Players = 6,
            };

            Shoe shoe = new Shoe
            {
                Brand = "Adidas",
                Model = "Stan Smith",
                Color = "Green",
            };

            Movie movie = new Movie
            {
                Title = "Spider-Man",
                Director = "Sam Raimi",
                Actor = "Tobey Maguire",
            };

            car1.DriveCar();
            car1.ImportCar();
            car2.DriveCar();
            car2.ImportCar();
            Console.WriteLine();

            sport.PlaySport();
            sport.CountPlayers();
            Console.WriteLine();

            shoe.BuyShoe();
            shoe.WearShoe();
            Console.WriteLine();

            movie.WatchMovie();
            movie.ShowDirector();
        }
    }
}
