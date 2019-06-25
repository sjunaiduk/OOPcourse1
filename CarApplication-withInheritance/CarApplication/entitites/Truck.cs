﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.entitites
{
   public class Truck : Vehicle
    {
      

        public Truck()
        {
            Type = "Truck";
        }

        public override decimal CalculatePrice()
        {
            return (1.5m * Price);
        }

    }
}
