using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBinaryTree
{
    class Program
    {

        static Node node = null;
        static List<int> preOrderValues;
        static List<int> postOrderValues;
        static List<int> inOrderValues;
        static List<int> descendingValues;

        private class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int? Key { get; set; }
        }

        static void insert(Node node, int? value)
        {
            if (node!=null && node.Key.HasValue)
            {
                if (value < node.Key.Value)
                {
                    Console.WriteLine($"  value {value} < node.value {node.Key}");
                    insert(node.Left, value);
                }
                else
                {
                    Console.WriteLine($"  value {value} > node.value {node.Key}");
                    insert(node.Right, value);
                }
            }
            else {
                node.Key = value;
                node.Left = new Node();
                node.Right = new Node();
            }
        }


        static void Main(string[] args)
        {
            int[] values = { 5, 10, 12, 3, 4, 1 };
            node = new Node();

            foreach (int v in values)
            {
                insert(node, v);
            }

            preOrderValues = new List<int>();
            printPreOrder(node);
            Console.WriteLine("\npreOrderValues: " + String.Join(",", preOrderValues.ToArray()));

            postOrderValues = new List<int>();
            printPostOrder(node);
            Console.WriteLine("\npostOrderValues: " + String.Join(",", postOrderValues.ToArray()));

            inOrderValues = new List<int>();
            printInOrder(node);
            Console.WriteLine("\ninOrderValues: " + String.Join(",", inOrderValues.ToArray()));


            descendingValues = new List<int>();
            printDescendingOrder(node);
            Console.WriteLine("\ndescendingValues: " + String.Join(",", descendingValues.ToArray()));

            testSearch(12);
            testSearch(0);
            testSearch(3);
            testSearch(2);

            Console.WriteLine("\nPress any key to continue");
            Console.Read();
        }

        private static void testSearch(int value)
        {
            Node found = search(node, value);
            if (found is null)
                Console.WriteLine($"Not found: {value}");
            else
                Console.WriteLine($"Found: {found.Key.Value}");
        }

        static void printPreOrder(Node root) {
            if (root == null) return;

            if (root.Key.HasValue)
            {
                preOrderValues.Add(root.Key.Value);
                //Console.WriteLine(root.Key);
            }

            if (root.Left!=null) printPreOrder(root.Left);
            if (root.Right != null) printPreOrder(root.Right);
        }

        static void printPostOrder(Node root)
        {
            if (root == null) return;
            
            if (root.Left != null) printPostOrder(root.Left);
            if (root.Right != null) printPostOrder(root.Right);

            if (root.Key.HasValue)
            {
                postOrderValues.Add(root.Key.Value);
                //Console.WriteLine(root.Key);
            }
        }

        static void printInOrder(Node root)
        {
            if (root == null) return;

            if (root.Left != null) printInOrder(root.Left);
            if (root.Key.HasValue)
            {
                inOrderValues.Add(root.Key.Value);
                //Console.WriteLine(root.Key);
            }
            if (root.Right != null) printInOrder(root.Right);
        }

        static void printDescendingOrder(Node root)
        {
            if (root == null) return;

            if (root.Left != null) printDescendingOrder(root.Right);
            if (root.Key.HasValue)
            {
                descendingValues.Add(root.Key.Value);
                //Console.WriteLine(root.Key);
            }
            if (root.Right != null) printDescendingOrder(root.Left);
        }

        static Node search(Node root, int value) {
            if (!root.Key.HasValue)
                return null;

            if (value == root.Key.Value)
            {
                return root;
            }
            else if (value < root.Key.Value)
                return search(root.Left, value);
            else
                return search(root.Right, value);

        }
    }
}
