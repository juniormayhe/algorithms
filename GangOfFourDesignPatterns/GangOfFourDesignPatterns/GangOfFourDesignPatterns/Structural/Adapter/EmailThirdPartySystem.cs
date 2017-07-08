using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Adaptee represents functionality required by client.
    /// its functionality is not compatible with client
    /// </summary>
    public class EmailThirdPartySystem
    {
        /// <summary>
        /// fake a third party method for retrieving global address book
        /// </summary>
        public string[] AddressLists {
            get
            {
                return new string[] { "junior@google.com", "julia@outlook.com", "johanna@yahoo.com" };
            }
        }
    }
}
