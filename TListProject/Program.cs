using System;

namespace TListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The program will call 'testList1.length'.");
            TList testList1 = new TList(new TNode("D"));
            testList1.push("C");
            testList1.push("B");
            testList1.push("A");
            testList1.print();
            if (testList1.length() == 4) { Console.WriteLine("Test 1 passed"); }
            else { Console.WriteLine("Test 1 failed"); }
            TList testList2 = new TList();
            if (testList2.length() == 0) { Console.WriteLine("Test 1 passed"); }
            else { Console.WriteLine("Test 1 failed"); }

        }
    }
}