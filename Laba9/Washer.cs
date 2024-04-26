using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Washer
    {
        public void Wash(Car car) => Console.WriteLine($"Машина {car.brand}, {car.model} помыта");
    }
}
