using System;
using VehicleCarTruckLibrary;
using System.Collections.Generic;

namespace VehicleCarandtruck {
    class Program {
        static void Main(string[] args) {

            var Car1 = new Car("12345", "Honda", "Civic", "Sport", 20800, true, false, false);
            var Car2 = new Car("12346", "Toyota", "Prius", "EX", 22800, false, true, true);
            var Car3 = new Car("12347", "Tesla", "X", "Sport", 32800, true, false, true);

            var Truck1 = new Truck("12348", "Ford", "F150", "Raptor", 39800, false, false, "8 Feet");
            var Truck2 = new Truck("12349", "Toyota", "BigTruck", "Rlly Big", 99800, true, true, "80 Feet");
            var Truck3 = new Truck("12340", "Faketruck", "Notreal", "Super big", 1039800, true, false, "800 Feet");

            var vhcls = new List<Vehicle>() { Car1, Car2, Car3, Truck1, Truck2, T
                ruck3 };
            foreach (var vhcl in vhcls) {
                Console.WriteLine(vhcl.Print());
            }
        }
    }
}
