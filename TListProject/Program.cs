using System;

namespace TListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The program will call creates a list, calls 'testList1.push('E')' and tests the length to ensure the list is the correct length.");
            TList testList1 = new TList(new TNode("D", new TNode("C", new TNode("B", new TNode("A")))));
            testList1.push("E");
            if (testList1.length() == 5) { Console.WriteLine("Test 1 passed"); }
            else { Console.WriteLine("Test 1 failed"); }
            TList testList2 = new TList();
            testList2.push("A");
            if (testList2.length() == 1) { Console.WriteLine("Test 2 passed"); }
            else { Console.WriteLine("Test 2 failed"); }

        }
    }
}