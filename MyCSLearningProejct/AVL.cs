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
                BalanceTree(ref root);

            Console.WriteLine("---");
            base.OutputPreOrder(root);
            Console.WriteLine("---");
        }

        public void BalanceTree(ref Node1 node)
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
            if (node == null)
                return;
            else
            {
                node.leftNode.parentNode = node;
                node.rightNode.parentNode = node;

                SeftParenting(ref node.leftNode);
                SeftParenting(ref node.rightNode);
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
            Node1 newRoot = node.rightNode;
            Node1 rotate = node;
            Node1 rotate1 = newRoot.leftNode;
            newRoot.leftNode = rotate;
            rotate.rightNode = rotate1;
            
            node = newRoot;
        }

        public void RotateRight(ref Node1 node)
        {
            //Node1 newRoot = node.leftNode;
            //Node1 rotate = node;
            //Node1 rotate1 = newRoot.rightNode;
            //newRoot.rightNode = rotate;
            //rotate.leftNode = rotate1;

            //node = newRoot;

            Node1 parent = node.parentNode;
            Node1 leftNode = node.leftNode;
            node.leftNode = leftNode.rightNode;
            leftNode.rightNode = node;

            if (parent != null)
            {
                if (parent.value > leftNode.value)
                    parent.leftNode = leftNode;
                else
                {
                    parent.rightNode = leftNode;
                }


                
            }


            node = leftNode;
            SeftParenting(ref root);
        }

    }
}
