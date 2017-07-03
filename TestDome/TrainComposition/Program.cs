using System;
using System.Collections.Generic;
public class TrainComposition
{
    LinkedList<int> composition;
    public TrainComposition(){
        composition = new LinkedList<int>();
    }
    public void AttachWagonFromLeft(int wagonId)
    {
        composition.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        composition.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        LinkedListNode<int> node = composition.First;
        composition.RemoveFirst();
        return node.Value;
    }

    public int DetachWagonFromRight()
    {
        LinkedListNode<int> node = composition.Last;
        composition.RemoveLast();
        return node.Value;
    }

    public static void Main(string[] args)
    {
        TrainComposition tree = new TrainComposition();
        tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    }
}