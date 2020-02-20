using System;

namespace TListProject
{
    class Program
    {
        static void Main(string[] args)
        {


            TList testList1 = new TList(new TNode("D"));
            testList1.push("C");
            testList1.push("B");
            testList1.push("A");
            testList1.print();
            TList testList2 = testList1.reverse();
            testList2.print();
            //testList1.merge(testList2);
           // testList1.print();
        }
    }
}