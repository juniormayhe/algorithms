using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// concrete product
    /// </summary>
    public class Bike : IProduct
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive the Bike {km} km");
        }
    }
}
