using System;

namespace GangOfFourDesignPatterns.Structural.Façade
{
    internal class PlaneCatering
    {
        string[] _food = { };
        
        public void PrepareFood(string[] food)
        {
            _food = food;
            Console.WriteLine($"Food prepared: {String.Join(",", _food)}");

        }
    }
}