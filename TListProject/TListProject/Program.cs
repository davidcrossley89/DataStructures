using System;

namespace TListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            TList testList = new TList(new TNode("D"));
            testList.push("C");
            testList.push("B");
            testList.push("A");
            Console.WriteLine("Base List: ");
            testList.print();
            Console.WriteLine();
            testList.insert(1, "E");
            Console.WriteLine("Insert E at index 1:");
            testList.print();
            Console.WriteLine();
            testList.remove(3);
            Console.WriteLine("Remove index 3");
            testList.print();
        }
    }
}