using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// GoogleStock is a concrete subject that causes 
    /// change to its state and notify all observers
    /// </summary>
    class Stock : ObservableStock
    {
        private double _stockPrice;

        //get current price
        public double GetStockPrice() => _stockPrice;

        //publish new stock price
        public void ChangePrice(double price)
        {
            _stockPrice = price;
            
            //notify changes
            this.Notifiy();
        }


    }
}
