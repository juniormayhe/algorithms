using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Creational.Singleton
{
    public class SystemSettings
    {
        private static SystemSettings _instance;
        private static object _lockSynchornization;

        private string _appName { get; set; }
        

        static SystemSettings() {
            _lockSynchornization = new object();
            _instance = null;
        }

        private SystemSettings() {
            //load some systems settings only once
            _appName = "GangOfFour Singleton";
            
        }

        public static SystemSettings Instance {
            get {
                //add suport to multithreaded applications
                lock (_lockSynchornization)
                {
                    if (_instance == null)
                        _instance = new SystemSettings();
                }//lock
                return _instance;
            }
        }

        public String GetAppName()=> $"AppName is {_appName}";
        

    }
}
