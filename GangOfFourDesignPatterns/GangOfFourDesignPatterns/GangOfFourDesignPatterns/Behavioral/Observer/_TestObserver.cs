
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFourDesignPatterns.Behavioral.Observer
{
    class _TestObserver
    {
        public void Run(int i)
        {
            Console.WriteLine($"\n{i}) Observer\nObserver pattern allows a single object, known as the subject, to publish changes to its state and other observer objects that depend upon the subject are automatically notified of any changes to the subject's state.\n");

            //concrete subject
            var googleStock = new Stock();
            //add concrete observers
            googleStock.Add(new GoogleInvestorObserver(googleStock, "Julia"));
            googleStock.Add(new GoogleInvestorObserver(googleStock, "Johanna"));
            googleStock.Add(new GoogleInvestorObserver(googleStock, "Junior"));
            
            //change price 
            googleStock.ChangePrice(918);
            //notify changes to all investors who are monitoring
            //googleStock.Notifiy();

            Debug.Assert(googleStock.GetStockPrice() == 918, "Stock price is wrong");

            //change price 
            googleStock.ChangePrice(919);
            //notify changes to all investors who are monitoring
            //googleStock.Notifiy();
            
            Debug.Assert(googleStock.GetStockPrice() == 919, "Stock price is wrong");


        }
    }
}
