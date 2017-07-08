using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Adapter class is responsible for consuming a third party system 
    /// and return the expected result as declared in ITarget
    /// This Adapter is passed as argument to constructor of Client class
    /// </summary>
    public class Adapter : EmailThirdPartySystem, IEmailSystemCatalog
    {
        public List<string> GetEmails()
        {
            //run thirdparty method from adaptee / base class
            string[] emailsFromThirdParty = this.AddressLists;
            
            //do your transformation here and then return the expected result for client
            return emailsFromThirdParty.ToList();
        }
    }
}
