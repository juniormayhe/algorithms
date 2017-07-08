using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatryoshkaDollApp
{
    public class MatryoshkaDoll
    {
        private readonly MatryoshkaDoll containedDoll;
        private int counter = 0;
        public MatryoshkaDoll() { }

        public MatryoshkaDoll(MatryoshkaDoll containedDoll)
        {
            this.containedDoll = containedDoll;
        }

        
        private int count(MatryoshkaDoll doll, ref int i) {
            if (doll.containedDoll != null) { 
                i++;
                return count(doll.containedDoll, ref i);
            }
            return i;
        }

        public int NumberOfSmallerDolls
        {
            get
            {
                return count(this, ref counter);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(new MatryoshkaDoll(new MatryoshkaDoll()).NumberOfSmallerDolls);
            Console.WriteLine(new MatryoshkaDoll(new MatryoshkaDoll(new MatryoshkaDoll())).NumberOfSmallerDolls);
            Console.Read();
        }
    }
}
