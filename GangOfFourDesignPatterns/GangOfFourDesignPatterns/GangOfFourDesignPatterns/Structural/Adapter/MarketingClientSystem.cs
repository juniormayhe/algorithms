using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Client class which will interact with a incompatible email 
    /// system that holds a Global address Book with email contacts
    /// </summary>
    public class MarketingClientSystem
    {
        private IEmailSystemCatalog _emailSystemCatalog;
        
        public bool Processed { get; set; }
        /// <summary>
        /// Client class must be instantiated with an adapter class 
        /// which implements a contract in ITarget class
        /// </summary>
        /// <param name="emailSystemCatalog"></param>
        public MarketingClientSystem(IEmailSystemCatalog emailSystemCatalog)
        {
            _emailSystemCatalog = emailSystemCatalog;
        }

        /// <summary>
        /// makes the request to thirdparty email system
        /// </summary>
        public void ProcessEmails() {
            //call method from adapter which implements ITarget
            List<string> emails = _emailSystemCatalog.GetEmails();

            foreach (var email in emails) {
                Console.WriteLine($"  retrived contact from third party email system: {email}");
            }
            Processed = true;
        }
    }
}
