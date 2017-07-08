using System;
namespace GangOfFourDesignPatterns.Structural.Façade
{
    internal class PlaneFlightPlan
    {
        string _flightPlan = "";

        public void PlanFlight(string flightPlan)
        {
            _flightPlan = flightPlan;
            Console.WriteLine($"Flight planned: {String.Join(",", _flightPlan)}");

        }
    }
}