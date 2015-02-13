using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4_Vehicle_App.Models
{
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public int Torque { get; set; }
        public int Cylinders { get; set; }

        public VehicleType VehicleType { get; set; }
        public int Price { get; set; }

        public int ID { get; set; }

        public Vehicle(int year, string make, string model, int hp, int torque, int cylinders, VehicleType type, int price, int id)
        {
            Year = year;
            Make = make;
            Model = model;
            Horsepower = hp;
            Torque = torque;
            Cylinders = cylinders;
            VehicleType = type;
            Price = price;
            ID = id;
        }
    }

    public enum VehicleType
    {
        Car,
        Motorcycle,
        Truck
    }
}