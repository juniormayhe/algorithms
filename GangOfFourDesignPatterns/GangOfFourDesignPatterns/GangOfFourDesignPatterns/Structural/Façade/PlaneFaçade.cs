using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Structural.Façade
{
    /// <summary>
    /// Façade which wraps all classes and members required by a client
    /// </summary>
    public class PlaneFaçade
    {

        PlaneCrew _crew;
        PlaneCatering _catering;
        PlaneFlightPlan _flightPlan;

        public Boolean Prepared { get; set; }

        public PlaneFaçade() {
            _crew = new PlaneCrew();
            _catering = new PlaneCatering();
            _flightPlan = new PlaneFlightPlan();
        }

        public void PreparePlane() {
            Console.WriteLine("Preparing plane...");
            _crew.AssembleCrew(new string[] { "John", "Marta"});
            _catering.PrepareFood(new string[] { "Coke", "Sandwich" });
            _flightPlan.PlanFlight("Start fligth at 5 o'clock at the Cape Town airport");
            Prepared = true;
            Console.WriteLine("Plane prepared.");
        }
    }
}
