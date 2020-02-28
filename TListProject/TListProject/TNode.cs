using System;

public class TNode
{
	public string data { get; set; }
	public  TNode next { get; set; }
	public bool isLast { get; set; } = true;

	public TNode()
	{
	}
	public TNode(string startingData)
	{
		this.data = startingData;
	}
	public TNode(string startingData, TNode node)
	{
		this.data = startingData;
		this.next = node;
	}
	
	public void printAll() //prints all following nodes
	{
		Console.Write(this.data);
		if (this.isLast) { }
		else{ next.printAll(); }
	}
	public void print() //prints only this node
	{
		Console.Write(this.data);
	}
	public void addNext(TNode node)
	{
		this.next = node;
		this.isLast = false;
	}
	public void insert(int index,TNode node)
	{
		if (index == 0)
		{
			node.addNext(this.next);
			this.addNext(node);
		}
		else if (this.isLast)
		{
			Console.WriteLine("List does not contain the given index");
		}
		else
		{
			next.insert(index - 1, node);
		}
	}
	public void remove(int index, TNode previous)
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
