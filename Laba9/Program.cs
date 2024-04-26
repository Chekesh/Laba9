using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class Program
    {
        delegate void WashCar(Car car);
        static void Main(string[] args)
        {
            Car bmwi7 = new Car("BMW", "i7", "Чекушин Н.С.", "A893CB");
            Car ChevroletCamaro = new Car("Chevrolet", "Camaro", "Чекушин Н.С.", "C888AP");
            Garage garage = new Garage(bmwi7, ChevroletCamaro);
            Washer washer = new Washer();

            WashCar washCar = washer.Wash;
            washCar(bmwi7);
            washCar(ChevroletCamaro);
            Console.Read();
        }
    }
}
