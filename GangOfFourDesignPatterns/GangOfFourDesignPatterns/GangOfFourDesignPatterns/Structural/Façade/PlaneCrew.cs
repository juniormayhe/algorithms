using System;

namespace GangOfFourDesignPatterns.Structural.Façade
{
    internal class PlaneCrew
    {
        string[] _crew = { };
        public void AssembleCrew(string[] crew) {
            _crew = crew;
            Console.WriteLine($"Crew assembled: {String.Join(",", _crew)}");

        }
    }
}