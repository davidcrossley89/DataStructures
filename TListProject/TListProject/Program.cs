using System;

namespace TListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TNode testNode = new TNode("A");
            TList testList = new TList(testNode);
            TNode secondNode = new TNode("B");
            testNode.setNext(secondNode);
            
            //testList.addToFront("B");
            testList.TPrint();
        }
    }
}