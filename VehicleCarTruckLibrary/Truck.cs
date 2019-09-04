using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLibrary {
   public class Truck : Vehicle {
        public bool Cap { get; set; }
        public bool Diesel { get; set; }
        public string BedSize { get; set; }

        public Truck(string vin, string make, string model, string trim, decimal price, bool cap, bool diesel, string bedsize)
            : base(vin, make, model, trim, price) {
            this.Cap = cap;
            this.Diesel = diesel;
            this.BedSize = bedsize;
        }
        public override string Print() {
              return base.Print() + $"|Cap: {Cap}| |Diesel:{Diesel}| |Bedsize: {BedSize}|";
            }
        }
    }

