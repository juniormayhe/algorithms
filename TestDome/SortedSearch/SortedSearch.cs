using System;
using System.Linq;
public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        
        return sortedArray.Where(x=>x<lessThan).Count();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}