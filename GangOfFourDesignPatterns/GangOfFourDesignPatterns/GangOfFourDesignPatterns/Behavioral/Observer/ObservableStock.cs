using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Subject contains a collection of observers that will 
    /// receive notification when a Stock price change
    /// </summary>
    public abstract class ObservableStock
    {
        //objects following up changes
        ArrayList _observers;

        public ObservableStock()
        {
            _observers = new ArrayList();
        }

        /// <summary>
        /// adds an observer interested in follow up
        /// subject / stock changes
        /// </summary>
        /// <param name="observer"></param>
        public void Add(IObserver observer) {
            _observers.Add(observer);
        }

        /// <summary>
        /// removes an observer 
        /// </summary>
        /// <param name="observer"></param>
        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notifiy() {
            foreach (IObserver o in _observers) {
                o.Update();
            }
        }
    }
}
