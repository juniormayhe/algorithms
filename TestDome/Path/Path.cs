using System;
using System.Collections.Generic;
using System.Linq;
public class Path
{
    public string CurrentPath { get; private set; }

    public Path(string path)
    {
        this.CurrentPath = path;
    }

    public void Cd(string newPath)
    {
        List<string> newCurrentPathTokens = new List<string>();
        List<string> currentPathTokens = new List<string>(this.CurrentPath.Split('/'));
        string[] newPathTokens = newPath.Split('/');
        int skip = 0;
        foreach (String s in newPathTokens){
            if (s == ".."){
                //remove last element from current path
                currentPathTokens.RemoveAt(currentPathTokens.Count - 1);    
                skip++;
            }
        }
        
		//there were relative folder navigation with ..
        if (skip>0){
            //gets path only without leading ".."
            newCurrentPathTokens = newPathTokens.Skip(skip).Take(newPathTokens.Count()).ToList();
            
            //adds newpath to current path
            currentPathTokens.AddRange(newCurrentPathTokens);
        }
        else
        {
            var teste = newPathTokens.Intersect(currentPathTokens).ToList();
            if (teste.Count()==1){
				//paths are completely different
                currentPathTokens.Clear();
                currentPathTokens.AddRange(newPathTokens);
            }
            else{
				//paths matches folder structure
                currentPathTokens.AddRange(newPathTokens);
            }
            
        }
        //set new path
        this.CurrentPath= String.Join("/",currentPathTokens.ToArray());
        
    }

    public static void Main(string[] args)
    {
        Path path = new Path("/a/b/c/d");
        path.Cd("../x");
        Console.WriteLine(path.CurrentPath);
    }
}
