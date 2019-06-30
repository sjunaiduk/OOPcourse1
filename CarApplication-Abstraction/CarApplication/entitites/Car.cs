using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.entitites
{
   public class Car : Vehicle
    {



        public Car()
        {
            Type = "Car";
        }

        public override decimal CalculatePrice()
        {
            return (Price * 1.8m);
        }
    }
}
