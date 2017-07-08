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
        private Stock _googleStock;
        private string _investorName;

        //pass concrete class that should be observed
        public GoogleInvestorObserver(Stock g, string investorName)
        {
            _googleStock = g;
            _investorName = investorName;
        }

        public void Update()
        {
            double stockPrice = _googleStock.GetStockPrice();
            Console.WriteLine($"   updated stock price: {stockPrice}, investor {_investorName}");
        }
    }
}
