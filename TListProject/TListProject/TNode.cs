using System;

internal class TNode
{
	internal string data { get; set; }
	internal TNode? next { get; set; }
	public TNode(string startingData)	{this.data = startingData;}
	internal TNode(string startingData, TNode node)
	{
		this.data = startingData;
		this.addNext(node);
	}
	internal void printAll() //prints all following nodes
	{
		Console.Write(this.data);
		if (this.next != null) { next.printAll(); }
		else { Console.WriteLine(); }
	}
	internal void print() //prints only this node, currently not used
	{
		Console.Write(this.data);
	}
	internal void addNext(TNode node) //Adds a node next in the list
	{
		this.next = node;
	}
	internal void insert(int index,TNode node) //used recursively to insert a value into a specified index
	{
		if (index == 0)
		{
			if (this.next == null){this.addNext(node);}
			else
			{
				node.addNext(this.next);
				this.addNext(node);
			}
		}
		else
		{
			next.insert(index - 1, node);
		}
	}
	internal void remove(int index) //used recursively to remove a node at a specified index
	{
		if (index == 1)
		{
			this.next = this.next.next;
		}
		else
		{
			this.next.remove(index - 1);
		}
	}
}
