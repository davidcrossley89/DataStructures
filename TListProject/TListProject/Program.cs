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
            testList.insert(1, "E");
            testList.print();
            testList.remove(3);
            testList.print();
            Console.WriteLine();
            Console.WriteLine(testList.pop());
            testList.print();
        }
    }
}