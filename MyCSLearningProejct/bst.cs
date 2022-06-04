﻿using System;
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
        /*
         
                6
              3   8
             1   7 12      
         
         
         */

        public int TotalNodeInTree(Node1 node)
        {
            int sum = 0;
            if (node == null)
            {
                return 0;
            }
            else
            {
                sum += TotalNodeInTree(node.leftNode);
                sum += TotalNodeInTree(node.rightNode);
                sum++;
            }
            return sum;
        }
        public int CompareHeight(int lHeight,int rHeight)
        { 
            if (lHeight >= rHeight)
               return lHeight;
            else
               return rHeight;
            //giang lai cho nay ly do return
        }
        public int GetTreeHeight(Node1 node)
        {
            int compare;
            if (node == null)
            {
                return 0;
            }
            else
            {
                int lHegight = 0;
                int rHegight = 0;
                lHegight= GetTreeHeight(node.leftNode)+1;
                rHegight= GetTreeHeight(node.rightNode)+1;
                compare=CompareHeight(rHegight, lHegight);
            }
            return compare;
        }
        public Node1 FindTheSmallestNode(Node1 node)
        {
            if (node.leftNode == null)
            {
                return node;
            }
            else
            {
                return FindTheSmallestNode(node.leftNode);
            }
        }

        public Node1 FindTheLargestNode(Node1 node)
        {
            if (node.rightNode == null)
            {
                return node;
            }
            else
            {
                return FindTheLargestNode(node.rightNode);
            }
        }
        public Node1 FindNodeWithValue(Node1 node, int valueToFind) // 1
        {
            if (node == null)
            {
                return null;
            }
            else if (node.value == valueToFind)
            {
                return node;
            }
            else
            {
                if (valueToFind < node.value)
                {
                   return FindNodeWithValue(node.leftNode, valueToFind);
                }
                else
                {
                   return FindNodeWithValue(node.rightNode, valueToFind);
                }
            }
            
        }
        public Node1 FindParentOfNode(Node1 node, Node1 nodeToFind)
        {
            if (node == null)
            {
                return null;
            }
            else if (node.leftNode == nodeToFind)
            {
                return node;
            }
            else if (node.rightNode == nodeToFind)
            {
                return node;
            }
            else
            {
                if (nodeToFind.value < node.value)
                {
                    return FindParentOfNode(node.leftNode, nodeToFind);
                }
                else
                {
                    return FindParentOfNode(node.rightNode, nodeToFind);
                }
            }
        }
        public Node1 FindTheSecondSmallestNode(Node1 node)
        {
            Node1 smallestNode = FindTheSmallestNode(node);
            if (smallestNode.rightNode == null)
            {
                return FindParentOfNode(node, smallestNode);
            }
            else
            {
                return FindTheSmallestNode(smallestNode.rightNode);
            }
        }
        public int FindNumOfLeavesNodeInTree(Node1 node)
        {
            int sum = 0;
            if (node.rightNode == null && node.rightNode == null)
            {
                return 1;
            }
            else
            {
                sum += FindNumOfLeavesNodeInTree(node.leftNode);
                sum += FindNumOfLeavesNodeInTree(node.rightNode);

            }
            return sum;
        }

    }


}