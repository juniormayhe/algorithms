using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSearch
{
    class Program
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {

            //Console.WriteLine($"\nTrying to find numbers less than {lessThan} in {String.Join(",", sortedArray)} ***********");

            //int end = Array.BinarySearch(sortedArray, lessThan);
            //int[] firstDestinationArray = { };
            //if (end < 0)
            //{
            //    end = ~end;
            //    if (end == sortedArray.Length)
            //        return end;
            //}

            //firstDestinationArray = new int[end];
            //Array.Copy(sortedArray, 0, firstDestinationArray, 0, end);

            //return CountNumbers(firstDestinationArray, lessThan);

            //int count = 0;
            //object l = new object();
            //var hs = new HashSet<int>(sortedArray);
            //Parallel.For(0, sortedArray.Length, (i) => {
            //    if (hs.ElementAt(i) < lessThan)
            //        lock(l){
            //            count++;
            //        }
            //});
            //return count;
            
            

            //Console.WriteLine("< {0}, Nearest index {1}, Value {2}",lessThan, nearest, sortedArray[nearest-1]);
            return sortedArray.Length;


        }
        

        public static void Main(string[] args)
        {

            //Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 7, 9 }, 4));
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 7, 9 }, 5));
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 7, 9 }, 6));
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 7, 9 }, 7));
            Console.WriteLine(CountNumbers(new int[] { 1, 3, 5, 7, 9 }, 8));
            Console.ReadLine();
        }
    }
}