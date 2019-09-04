using System;

namespace VehicleCarTruckLibrary {
    public class Vehicle {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string vin, string make, string model, string trim, decimal price) {
            this.Vin = vin;
            this.Make = make;
            this.Model = model;
            this.Trim = trim;
            this.Price = price;
        }
            public virtual string Print() {
                return $"|Vin: {Vin}| |Make: {Make}| |Model: {Model}| |Trim:{Trim}| |Price:{Price.ToString("C")}| ";
            }
        }

    }

