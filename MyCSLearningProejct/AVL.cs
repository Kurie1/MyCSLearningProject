using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearningProejct
{
    public class AVL : BST
    {
        public AVL() : base() { }

        public override void Add(int value)
        {
            base.Add(value);

            if (!IsBalance(root))
                BalanceTree(root);

            Console.WriteLine("---");
            base.OutputPreOrder(root);
            Console.WriteLine("\n---");
        }

        public void BalanceTree(Node1 node)
        {
            Node1 unbalanceNode = GetUnbalanceNode(node); 
            int leftHeight = GetTreeHeight(unbalanceNode.leftNode);
            int rightHeight = GetTreeHeight(unbalanceNode.rightNode);

            if (leftHeight > rightHeight)
            {
                leftHeight = GetTreeHeight(unbalanceNode.leftNode.leftNode);
                rightHeight = GetTreeHeight(unbalanceNode.leftNode.rightNode);
                if (leftHeight > rightHeight)
                {
                    // LL
                    RotateRight(ref unbalanceNode);
                }
                else
                {
                    // LR
                    RotateLeft(ref unbalanceNode.leftNode);
                    RotateRight(ref unbalanceNode);
                }
                
            }
            else
            {
                rightHeight = GetTreeHeight(unbalanceNode.rightNode.rightNode);
                leftHeight = GetTreeHeight(unbalanceNode.rightNode.leftNode);
                if (rightHeight > leftHeight)
                {
                    // RR
                    RotateLeft(ref unbalanceNode);
                }
                else
                {
                    // RL
                    RotateRight(ref unbalanceNode.rightNode);
                    RotateLeft(ref unbalanceNode);
                }
            }
        }

        public void SeftParenting(ref Node1 node)
        {
            root.parentNode = null;

            if (node == null)
                return;
            else
            {
                if (node.leftNode != null)
                {
                    node.leftNode.parentNode = node;
                    SeftParenting(ref node.leftNode);
                }

                if (node.rightNode != null)
                {
                    node.rightNode.parentNode = node;
                    SeftParenting(ref node.rightNode);
                }
            }
        }

        public Node1 GetUnbalanceNode(Node1 node)
        {
            bool isBalanceLeft = IsBalance(node.leftNode);
            bool isBalanceRight = IsBalance(node.rightNode);

            if (isBalanceLeft && isBalanceRight)
            {
                return node;
            }
            else
            {
                if (!isBalanceLeft)
                {
                    return GetUnbalanceNode(node.leftNode);
                }
                else
                {
                    return GetUnbalanceNode(node.rightNode);
                }
            }
        }

        public bool IsBalance(Node1 node)
        {
            if (node == null)
                return true;

            int leftHeight = GetTreeHeight(node.leftNode);
            int rightHeight = GetTreeHeight(node.rightNode);

            return MathF.Abs(leftHeight - rightHeight) <= 1;
        }

        public void RotateLeft(ref Node1 node)
        {
            Node1 parent = node.parentNode;
            Node1 rightNode = node.rightNode;
            node.rightNode = rightNode.leftNode;
            rightNode.leftNode = node;

            if (root == node)
                root = rightNode;
            else
            {
                node = rightNode;
            }

            if(parent!= null)
            {
                if(parent.value > node.value)
                {
                    parent.leftNode = node;
                }
                else
                {
                    parent.rightNode = node;
                }
            }


            SeftParenting(ref root);
        }

        public void RotateRight(ref Node1 node)
        {
            Node1 parent = node.parentNode;
            Node1 leftNode = node.leftNode;
            node.leftNode = leftNode.rightNode;
            leftNode.rightNode = node;

            if (root == node)
                root = leftNode;
            else
            {
                node = leftNode;
            }

            if (parent != null)
            {
                if (parent.value > node.value)
                {
                    parent.leftNode = node;
                }
                else
                {
                    parent.rightNode = node;
                }
            }

            SeftParenting(ref root);
        }

    }
}
