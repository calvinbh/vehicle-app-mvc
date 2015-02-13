using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4_Vehicle_App.Models
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int year, string make, string model, int hp, int torque, int cylinders, int price, int id)
            : base(year, make, model, hp, torque, cylinders, VehicleType.Motorcycle, price, id)
        {
        }

    }
}