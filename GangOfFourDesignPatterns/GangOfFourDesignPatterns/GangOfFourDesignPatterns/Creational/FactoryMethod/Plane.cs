using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// This is a class which implements methods of Product interface
    /// </summary>
    public class Plane : IProduct
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive the Plane {km} km");
        }
    }
}
