using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearningProejct
{

    public class Node1
    {
        public int value;
        public Node1 leftNode;
        public Node1 rightNode;

        public static Node1 CreateNode(int value)
        {
            Node1 newNode = new Node1();
            newNode.value = value;
            newNode.leftNode = null;
            newNode.rightNode = null;

            return newNode;
        }
    }

    public class BST
    {
        public Node1 root;

        public BST() //constructor
        {
            root = null;
        }

        public void Input()
        {
            int input = 0;
            Console.WriteLine("Please enter your input (-99 to exit):");

            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input != -99)
                {
                    Add(input);
                }
                else
                {
                    break;
                }
            }
        }

        public void Output()
        {
            OutputInOrder(root);
        }

        public void OutputPreOrder(Node1 node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.Write($"{node.value} ");
                OutputPreOrder(node.leftNode);
                OutputPreOrder(node.rightNode);
            }
        }

        public void OutputInOrder(Node1 node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                OutputInOrder(node.leftNode);
                Console.Write($"{node.value} ");
                OutputInOrder(node.rightNode);
            }
        }

        public void OutputPostOrder(Node1 node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                OutputPostOrder(node.leftNode);
                OutputPostOrder(node.rightNode);
                Console.Write($"{node.value} ");
            }
        }

        public void Add(int value)
        {
            Node1 newNode = Node1.CreateNode(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                AddHelper(newNode, ref root);
            }
        }

        public void AddHelper(Node1 nodeToAdd, ref Node1 nodeToCompare)
        {
            if (nodeToCompare == null)
            {
                nodeToCompare = nodeToAdd;
                return;
            }

            if (nodeToAdd.value >= nodeToCompare.value)
            {
                AddHelper(nodeToAdd, ref nodeToCompare.rightNode);
            }
            else
            {
                AddHelper(nodeToAdd, ref nodeToCompare.leftNode);
            }
        }
        

        public int TotalNodeInTree(Node1 node)
        {        
            
        }



    }

}