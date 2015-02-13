using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4_Vehicle_App.Models
{
    public class Truck : Vehicle
    {
        public Truck(int year, string make, string model, int hp, int torque, int cylinders, int price, int id)
            : base(year, make, model, hp, torque, cylinders, VehicleType.Truck, price, id)
        {
        }
    }
}