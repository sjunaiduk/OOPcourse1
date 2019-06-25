using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.entitites
{
   public class Motorcycle : Vehicle
    {
        
        public Motorcycle()
        {
            Type = "Motorcycle";
        }

        public override decimal CalculatePrice()
        {
            return (Price * 1.1m);
        }


    }
}
