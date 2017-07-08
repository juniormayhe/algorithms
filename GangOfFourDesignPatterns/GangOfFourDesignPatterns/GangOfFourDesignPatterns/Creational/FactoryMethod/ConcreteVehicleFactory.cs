using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// This is a class which implements the Creator class and overrides the factory 
    /// method to return an instance of a ConcreteProduct.
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IProduct GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Bike":
                    return new Bike();
                    
                case "Plane":
                    return new Plane();
                    
                default:
                    throw new ApplicationException($"No case for {vehicle}");
            }
        }
    }
}
