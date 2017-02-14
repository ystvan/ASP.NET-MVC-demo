using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BobDemoMVC.Models
{
    public class HelloModel
    {
        public static List<Car> GetCars()
        {
            //collection initializer
            List<Car> cars = new List<Car>
            {
                //object initializers
                new Car {Id = 1, Make = "BMW", Model = "528i"},
                new Car {Id = 1, Make = "Hunyadi", Model = "Elantra"},
                new Car {Id = 1, Make = "Toyota", Model = "4Runner"}

            };
            return cars;
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}