using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Creator abastract class which declares the factory method
    /// which returns an object of type IProduct
    /// 
    /// A creator doesn't know what classes it will be required to create.
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IProduct GetVehicle(string vehicle);
    }
}
