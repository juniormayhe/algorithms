using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.Singleton
{
    public class _TestSingleton
    {
        public void Run(int i) {
            Console.WriteLine($"\n{i}) Singleton\nSingleton pattern is one of the simplest design patterns. This pattern ensures that a class has only one instance and provides a global point of access to it.\n");
            Console.WriteLine(SystemSettings.Instance.GetAppName());
            Console.WriteLine(SystemSettings.Instance.GetAppName());
            
            Debug.Assert(SystemSettings.Instance.GetAppName() == "AppName is GangOfFour Singleton", "Return value from singleton is wrong");
            

        }
    }
}
