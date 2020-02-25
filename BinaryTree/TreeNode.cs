using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
     class TreeNode
    {
        private string data { get; set; } = null;
        private TreeNode left { get; set; } = null;
        private TreeNode right { get; set; } = null;

        public TreeNode() {}
        public TreeNode(string number) { data = number; }
        public TreeNode(string number, TreeNode newLeft) { data = number; left = newLeft; }
        public TreeNode(string number, TreeNode newLeft, TreeNode newRight) { data = number; left = newLeft; right = newRight; }

        public bool isLeftNull() { return (this.left == null); }
        public bool isRightNull() { return (this.right == null); }

        public string print()
        {
            string ans;
            string leftAns;
            string rightAns;
            
            if (isLeftNull()) leftAns = "";
            else leftAns = left.print();

            if (isRightNull()) rightAns = right.data;
            else rightAns = right.print();
            ans = "[" + leftAns + ","+rightAns +"]" ;
            return ans;

        }
        public int getHeight(int n)
        {
            if (this.isLeftNull()) { return n; }
            else return(left.getHeight(n + 1));
        }

        public bool isLeaf()
        {
            if (data != null) { return isLeftNull() && isRightNull(); }
            else return false;
        }
        public bool isFull()
        {
            if (isLeaf()) { return true; }
            else if (isRightNull()) { return false; }
            else return (left.isFull() && right.isFull());
        }
        public void Add(TreeNode node)
        {
            if (isLeftNull()) { left = node; }
            else if (isRightNull()) { right = node; }
            else if (left.isLeaf() && right.isLeaf()) { left.Add(node); }
            else if (left.isFull()) { right.Add(node); }
            else left.Add(node);
        }
    }
}
