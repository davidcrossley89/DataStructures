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
            testList.insert(4, "E");
            Console.WriteLine("Insert E at index 4:");
            testList.print();          
            Console.WriteLine();
            testList.remove(4);
            Console.WriteLine("Remove index 3");
            testList.print();

            TNode foo = new TNode("foo");
            TList loopTest = new TList(foo);
            TNode afterHead = new TNode("bunny",foo);
            TNode head = new TNode("Little",afterHead);
            head.insert(2, foo); //inserting foo causes a the list to loop around, so that afterHead.next = foo, so there is no last element.
            Console.WriteLine(loopTest.isLooped());

        }
    }
}