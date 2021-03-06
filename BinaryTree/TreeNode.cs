﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
     class TreeNode
    {
        internal int? data { get; set; } = null;
        internal TreeNode left { get; set; } = null;
        internal TreeNode right { get; set; } = null;

        public TreeNode() {}
        public TreeNode(int number) { data = number; }
        public TreeNode(int number, TreeNode newLeft) { data = number; left = newLeft; }
        public TreeNode(int number, TreeNode newLeft, TreeNode newRight) { data = number; left = newLeft; right = newRight; }

        public bool isLeftNull() { return (this.left == null); }
        public bool isRightNull() { return (this.right == null); }

        public string print()
        {
            string ans = data.ToString();
            string leftAns;
            string rightAns;
            
            if (isLeftNull()) leftAns = "";
            else leftAns = left.print();

            if (isRightNull()) rightAns = "";
            else rightAns = right.print();
            ans = ans +"[" + leftAns  +rightAns +"]" ;
            return ans;

        }
        public int getHeight(int n)
        {
            if (this.isLeftNull()) { return n; }
            else return(left.getHeight(n + 1));
        }
        public int getFullHeight(int n)
        {

            if (this.isLeftNull()) { return n; }
            else if (isRightNull()) { return n; }
            else
            {
                int lHeight = left.getFullHeight(n + 1);

                int rHeight =  right.getFullHeight(n + 1); 
                if (lHeight > rHeight) { return rHeight; }
                else return lHeight;
            }
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
        virtual public void Add(TreeNode node)
        {

            if (isLeftNull()) { left = node; }
            else if (isRightNull()) { right = node; }
            else if (left.getFullHeight(0) > right.getFullHeight(0)) { right.Add(node); }
            else left.Add(node);
        }
        /*public void Remove(string rData)
        {
            if (data == rData) { this.adjust}
        }
        */
        public ArrayList getAllNodes()
        {
            ArrayList answer = new ArrayList();
            answer.Add(data);
            if (!isLeftNull()) { answer.AddRange(left.getAllNodes()); }
            if (!isRightNull()) { answer.AddRange(right.getAllNodes()); }
            return answer;
        }
    }
}
