using System;
using System.Collections.Generic;
using System.Linq;
class TwoSum
{
	public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
	{
		var hs = new HashSet<int>();
		list.ToList().ForEach(x => hs.Add(x));

		for (int i = 0; i < hs.Count; i++)
		{
			var diff = sum - list[i];
			if (hs.Contains(diff))
			{
				var index = list.IndexOf(diff);
				return new Tuple<int, int>(i, index);
			}
		}
		return null;
	} 

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    }
}

/*
   public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        int size = list.Count;
        Tuple<int,int> indices = null;
        
        for (int i=0; i < size; i++){
            for (int j=0; j < size; j++){
                
                if (sum != list[i]+list[j])
                    continue;
                    
                indices = new Tuple<int, int>(i, j);
                return indices;

            }
        }
        return indices;
        
    }
*/

