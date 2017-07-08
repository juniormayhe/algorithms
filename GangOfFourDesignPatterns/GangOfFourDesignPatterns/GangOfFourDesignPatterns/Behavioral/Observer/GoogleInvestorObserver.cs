using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete observer implements Observer interface and 
    /// examines the subject to determine which information has changed.
    /// </summary>
    class GoogleInvestorObserver : IObserver
    {
        //subject to observe
        private Stock _stock;
        private string _investorName;

        //pass concrete class that should be observed
        public GoogleInvestorObserver(Stock stock, string investorName)
        {
            _stock = stock;
            _investorName = investorName;
        }

        public void Update()
        {
            double stockPrice = _stock.GetStockPrice();
            Console.WriteLine($"   updated stock price: {stockPrice}, investor {_investorName}");

        }
    }
}
