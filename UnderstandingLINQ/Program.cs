using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
            new Car() { VIN= "A1", Make = "BMW", Model= "550i", StickerPrice= 55000, Year = 2009},
            new Car() { VIN= "B2", Make = "Toyota", Model= "4Runner", StickerPrice= 35000, Year = 2010},
            new Car() { VIN= "C3", Make = "BMW", Model= "745li", StickerPrice= 75000, Year = 2008},
            new Car() { VIN= "D4", Make = "Ford", Model= "Escape", StickerPrice= 25000, Year = 2008},
            new Car() { VIN= "E5", Make = "BMW", Model= "55i", StickerPrice= 57000, Year = 2010}
        };

            // LINQ Query - FIND ALL BMW IN THE LIST OF CARS IN myCars
            /*var bmws = from car in myCars
                       where car.Make == "BMW"5/
                       && car.Year == 2010
                       select car;
                       
            // Orders cars from decending order by year
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            // LINQ Method
            // Land expression (mini method)
            // given an instance in a collection return back to me, the instances of car which make is equal to "BMW"
            // var keyword is used to make the compiler work out what the data type is 
            // var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*
            //bmws (old collection)
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.VIN);
            }
            */

            /*
            //Method chaining - makes collection desending order ,then checks the first bmw in order
            var firstBmw = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");

            Console.WriteLine(firstBmw.VIN);
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:c}", p.VIN, p.StickerPrice));

            // Checks if a certain car model exist in the collection
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Console.WriteLine("{0:C}",myCars.Sum(p => p.StickerPrice));

            // Prints what type of data type it is
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW" 
                       && car.Year == 2010
                       // new anonmous type, that has 2 string types
                       select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());
            Console.ReadLine();
        }

        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public double StickerPrice { get; set; }
            public int Year { get; set; }
        }
    }
}
