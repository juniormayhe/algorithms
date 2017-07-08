using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.FactoryMethod
{
    public class _TestFactoryMethod
    {
        public void Run(int i) {
            Console.WriteLine($"\n{i}) Factory Method\nIn Factory Method pattern, we create object without exposing the creation logic. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate. The creation of object is done when it is required. The Factory method allows a class later instantiation to subclasses.\n");
            var factory = new ConcreteVehicleFactory();
            IProduct bike = factory.GetVehicle("Bike");
            bike.Drive(10);

            IProduct plane = factory.GetVehicle("Plane");
            plane.Drive(4400);

            Debug.Assert(bike.GetType() == typeof(Bike), "Type must be Bike");
            Debug.Assert(plane.GetType() == typeof(Plane), "Type must be Plane");

        }
    }
}
