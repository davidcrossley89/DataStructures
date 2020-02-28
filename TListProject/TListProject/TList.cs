using System;

public class TList
{
	public TNode head;		//Simple List: only knows it's own first node
	public TList(TNode node) //Constructor, given a node
	{
		head = node;
	}
	public TList(string node) //Constructor, given a string, it creates a new node
	{
		TNode startHead = new TNode(node);
		head = startHead;
	}

	public void addToFront(string nextNode) //add a single node to the front of a list.
	{
		TNode secondNode = this.head;
		
		TNode firstNode = new TNode(nextNode);
		head = firstNode;
		
		head.addNext(secondNode);
	}
	public void print()		//used to display all members of the list
	{
		if (head != null)
		{
			Console.WriteLine();
			head.printAll();
		}
		else { Console.WriteLine("Empty List"); }
	}
	public void insert(int index, TNode node)
	{
		if (this.head == null) {
			Console.WriteLine("List does not contain the given index");
		}
		else
		{
			head.insert(index, node);
		}
	}

	public void remove(int index)
	{
		if (this.head == null)
		{
			Console.WriteLine("List does not contain the given index");
		}
		else if (index == 0) 
		{
			head = head.next;
		}
		else
		{
			head.next.remove(index - 1, head);
		}
	}
}
