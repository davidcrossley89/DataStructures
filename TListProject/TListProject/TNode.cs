using System;

public class TNode
{
	public string data { get; set; }
	public  TNode next { get; set; }
	public bool isLast { get; set; } = true;

	public TNode(string startingData)	{this.data = startingData;}
	public TNode(string startingData, TNode node)
	{
		this.data = startingData;
		this.next = node;
	}
	public void printAll() //prints all following nodes
	{
		Console.Write(this.data);
		if ( !this.isLast) { next.printAll(); }
	}
	public void print() //prints only this node
	{
		Console.Write(this.data);
	}
	public void addNext(TNode node) //Adds a node next in the list
	{
		this.next = node;
		this.isLast = false;
	}
	public void insert(int index,TNode node) //used recursively to insert a value into a specified index
	{
		if (index == 0)
		{
			node.addNext(this.next);
			this.addNext(node);
		}
		else
		{
			next.insert(index - 1, node);
		}
	}
	public void remove(int index, TNode previous) //used recursively to remove a node at a specified index
	{
		if (index == 0)
		{
			previous.next = this.next;
		}
		else
		{
			this.next.remove(index - 1, this);
		}
	}
}
