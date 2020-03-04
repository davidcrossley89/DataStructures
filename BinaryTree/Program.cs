using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] searchTest = new int[] { 5, 4, 8, 2, 3, 7, 5, 1 };
            Tree empTree = new Tree();
            //for (int num =0; num <=9; num++) { empTree.Add(new TreeNode(num)); }
            foreach (int num in searchTest) { empTree.Add(new BinarySearchNode(num)); }
            Console.WriteLine(empTree.isFull());


            empTree.printTree();
            Console.WriteLine();
            //Tree twoTree = empTree.merge(empTree.top.left, empTree.top.right);
            //twoTree.printTree();



        }
    }
}
