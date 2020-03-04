using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinarySearchNode : TreeNode
    {
        public BinarySearchNode(int num)
        {
            data = num;
        }
        public override void Add(TreeNode node)
        {
            int? addNum = node.data;

            if (addNum > data)
            {
                if (isRightNull()) { right = node; }
                else { right.Add(node); }
            }
            else
            {
                {
                    if (isLeftNull()) { left = node; }
                    else { left.Add(node); }
                }

            }
        }
    }
}
