using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        public TreeNode top { get; set; } = null;

        public Tree() { }
        public Tree(TreeNode node) { top = node; }

        public bool isNull() { return (this.top == null); }

        public void printTree()
        {
            if (this.isNull()) { Console.WriteLine("null"); }
            else  Console.WriteLine(top.print());

        }
        public int getHeight()
        {
            if (this.isNull()) { return 0; }
            else return top.getHeight(1);
        }
        public bool isFull()
        {
            if (this.isNull()) { return false; }
            else return top.isFull();
        }
        public void Add(TreeNode node)
        {
            if (this.isNull()) { this.top = node; }
            else top.Add(node);
        }
    }
}
