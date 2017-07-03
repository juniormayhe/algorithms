using System;
using System.Text;
using System.Collections.Generic;
public class TextInput {
    public IList<char> list = new List<char>();
    
    public String GetValue(){
        string r = "";
        foreach (char l in list)
        {
            r = r + l;
        }
        return r;
    }
    public virtual void Add(char c){
        list.Add(c);
    }
}

public class NumericInput : TextInput {
    public override void Add(char c){
        if (c < '0' || c > '9') { }
        else
            list.Add(c);
    }
    
}

public class UserInput
{
    public static void Main(string[] args)
    {
        //TextInput input = new NumericInput();
        TextInput input = new TextInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}