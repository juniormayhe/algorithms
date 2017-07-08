using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Structural.Façade
{
    class _TestFaçade
    {
        public void Run(int i)
        {
            
            Console.WriteLine($"\n{i}) Façade\nFacade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system.\n");

            var planFaçade = new PlaneFaçade();
            planFaçade.PreparePlane();

            Debug.Assert(planFaçade.Prepared, "Plane must be prepared");


        }
    }
}
