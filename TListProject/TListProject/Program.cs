using System;

namespace TListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TNode testNode = new TNode("A");
            TList testList = new TList(new TNode("D"));
            TList list2 = new TList(testNode);

            //TNode secondNode = new TNode("B");
            testList.addToFront("C");
            testList.print();
            list2.print();
        }
    }
}