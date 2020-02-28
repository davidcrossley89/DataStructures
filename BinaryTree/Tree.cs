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
            string treeOutput;
            if (this.isNull()) { treeOutput = "null"; }
            else  treeOutput =top.print();
            Console.WriteLine(treeOutput);
            int h = this.getHeight();
            List<char>[] outArray = new List<char>[h];
            foreach(List<char> level in outArray) { new List<char>(); }
            int currentLevel = 0;
            int spacesBetween = this.getHeight() *this.getHeight();
            foreach (char character in treeOutput)
            {
                if (character == '[') { currentLevel++;}
                else if (character == ']') { currentLevel = currentLevel - 1; }
                else if (outArray[currentLevel] == null) { outArray[currentLevel] = new List<char> {' '}; outArray[currentLevel].Add(character); }
                else { outArray[currentLevel].Add(character); }
            }
            foreach (List<char> level in outArray)
            {
                Console.WriteLine();

                foreach (char character in level)
                {
                    Console.Write(character);
                    for (int space = 0; space <= spacesBetween; space++)
                    {
                        Console.Write(' ');
                    }
                }
                spacesBetween = spacesBetween - this.getHeight();
            }

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
