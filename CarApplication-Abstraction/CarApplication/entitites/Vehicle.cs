using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.entitites
{
    public abstract class Vehicle
    {
        public string Make;
        public string Model;
        public string Colour;
        public string Type;

        public int GearNumber;

        public decimal Price=100;

        public abstract decimal CalculatePrice();

        public void ChangeGear()
        {
            return;
        }
      



    }
}
