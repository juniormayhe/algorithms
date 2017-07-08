using GangOfFourDesignPatterns.Behavioral.Observer;
using GangOfFourDesignPatterns.Creational.FactoryMethod;
using GangOfFourDesignPatterns.Creational.Singleton;
using GangOfFourDesignPatterns.Structural.Adapter;
using GangOfFourDesignPatterns.Structural.Façade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
 _____                            __  ______               
|  __ \                          / _| |  ___|              
| |  \/ __ _ _ __   __ _    ___ | |_  | |_ ___  _   _ _ __ 
| | __ / _` | '_ \ / _` |  / _ \|  _| |  _/ _ \| | | | '__|
| |_\ \ (_| | | | | (_| | | (_) | |   | || (_) | |_| | |   
 \____/\__,_|_| |_|\__, |  \___/|_|   \_| \___/ \__,_|_|   
                    __/ |                                  
                   |___/                                   ");
            int i=1;
            Console.WriteLine("Creational patterns -----------");
            var testFactory = new _TestFactoryMethod();
            testFactory.Run(i++);

            var testSingleton = new _TestSingleton();
            testSingleton.Run(i++);

            Console.WriteLine("Structural patterns -----------");
            var testFaçade = new _TestFaçade();
            testFaçade.Run(i++);
            
            var testAdapter = new _TestAdapter();
            testAdapter.Run(i++);

            Console.WriteLine("Behavioral patterns -----------");
            var testObserver = new _TestObserver();
            testObserver.Run(i++);


            Console.Read();
        }
    }
}
