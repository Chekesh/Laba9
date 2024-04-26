using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Garage
    {
        public Car[] cars {  get; set; }

        public Garage(params Car[] cars)
        {
            this.cars = cars;
        }
    }
}
