using System;

public class TList
{
	TNode head;		//Simple List: only knows it's own first node
	public TList(TNode node) //Constructor, given a node
	{
		TNode head = node;
	}
	public TList(string node) //Constructor, given a string, it creates a new node
	{
		TNode head = new TNode(node);
	}



	public void addToFront(string newVal) //add a single node to the front of a list.
	{
		TNode newNext = this.head;		//shifts all other values back in list
		this.head = new TNode(newVal);
		this.head.setNext(newNext);
		this.head.setLast(false);
	}
	public void TPrint()		//used to display all members of the list
	{
		TNode curNode = this.head;
		while (curNode.getLast() == false){
			curNode.print();
			curNode = curNode.getNext();
		}
	}


}
