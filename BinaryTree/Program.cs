using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode four = new TreeNode("4");
            TreeNode five = new TreeNode("5");
            TreeNode six = new TreeNode("6");
            TreeNode seven = new TreeNode("7");
            
            TreeNode two = new TreeNode("2");
            TreeNode three = new TreeNode("3");

            TreeNode one = new TreeNode("1");
            TreeNode a = new TreeNode("A");
            TreeNode b = new TreeNode("B");
            TreeNode c = new TreeNode("C");
            Tree tree = new Tree(one);

            Tree empTree = new Tree();
            Console.WriteLine(tree.isFull());
            Console.WriteLine(empTree.isFull());

            empTree.Add(one);
            empTree.Add(two);
            empTree.Add(three);
            empTree.Add(four);
            empTree.Add(five);
            empTree.Add(six);
            empTree.Add(seven);
            empTree.Add(a);
            empTree.Add(b);
            empTree.Add(c);

            empTree.printTree();

        }
    }
}
