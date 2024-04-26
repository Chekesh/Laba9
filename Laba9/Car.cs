using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Car
    {
        public string brand;
        public string model;
        public string owner;
        public string number;

        public Car(string brand, string model, string owner, string number)
        {
            this.brand = brand;
            this.model = model;
            this.owner = owner;
            this.number = number;
        }
    }
}
