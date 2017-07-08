using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Structural.Adapter
{
    class _TestAdapter
    {
        public void Run(int i) {
            Console.WriteLine($"\n{i}) Adapter\nThe Adapter pattern allows a system to use classes of another system that is incompatible with it.\n");

            var client = new MarketingClientSystem(new Adapter());
            client.ProcessEmails();
            
            Debug.Assert(client.Processed, "Processed must be true");

        }
    }
}
