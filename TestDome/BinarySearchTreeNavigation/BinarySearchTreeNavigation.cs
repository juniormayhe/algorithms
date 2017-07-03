/*
using System;
public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool IsValidBST(Node root)
    {
        bool leftValid = root.Left == null || root.Left.Value < root.Value;
        bool rightValid = root.Right == null || root.Right.Value> root.Value;
        
        Console.WriteLine("leftValid: {0}", leftValid);
        Console.WriteLine("rightValid: {0}", rightValid);
        
        if (root.Left == null && root.Right==null)
            return true;
        else if (leftValid && rightValid)
            return true;
        else 
            return false;
        
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(IsValidBST(n2));
        
    }
}
*/


/**/
using System;
using System.Collections.Generic;
using System.Linq;
public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool IsValidBST(Node root)
    {
        return IsBSTRecursion(root, int.MinValue, int.MaxValue);
    }
    
    static bool IsBSTRecursion(Node rootNode, int min, int max)
	{
		if (rootNode == null)
			return true;

		if (rootNode.Value  <= min || rootNode.Value >= max)
			return false;

		return IsBSTRecursion(rootNode.Left, min, rootNode.Value)
			   && IsBSTRecursion(rootNode.Right, rootNode.Value, max);
	}

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(IsValidBST(n2));
    }
}


/**/


using System;
using System.Collections.Generic;
using System.Linq;
public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool IsValidBST(Node root)
    {
        Stack<Node> s = new Stack<Node>();
        Node p = root;
        int? nVal = null; // previous value

        while (s.Count  != 0 || p  != null)
        {
            if (p != null)
            {
                s.Push(p);
                p = p.Left;
            }
            else
            {
                Node node = s.Pop();
                p = node.Right;
                if (nVal != null && nVal > node.Value)
                    return false;
                nVal = node.Value;
            }
        }
        return true;
 
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(IsValidBST(n2));
    }
}