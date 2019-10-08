 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // populate there values
            /*
            Car car1 = new Car();
            car1.VIN = "A1";
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.VIN = "A2";
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Matthew Bowyer";
            b1.Title = "C# Working With Collections";
            b1.ISBN = "0-000-00000-0";

            /* old style of array
            // ArrayList are dynamcially sized, (keep adding items)
            // can sort and remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            //myArrayList.Add(b1);

            //printing out all of the cars(specific element_
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List, is a specific list for a data type
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*

            // Dictionary<TKey, TValue> Tkey should be unique such as ID and value should any data type

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            // Finds the car in the array with the VIN value of "A2" the prints the make of the car
            Console.WriteLine(myDictionary["A2"].Make);
            Console.ReadLine();
            */

            // Array that has already been initalised
            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // Objects that have been initalised at the point of instiation
            // No need for a contructor
            // Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "BMW", Model = "750li", VIN = "D4" };

            // Collection initaliser
            List<Car> myList = new List<Car>() {
                new Car { Make = "BMW", Model = "750li", VIN = "D4" },
                new Car { Make = "Corsa", Model = "500", VIN = "E5"},
                new Car { Make = "Land Rover", Model = "Discovery", VIN = "F6"} };
            
            Console.ReadLine();
        }

        class Car
        {

            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }

    }
}
