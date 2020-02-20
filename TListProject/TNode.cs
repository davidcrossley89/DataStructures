using System;

public class TNode
{
	string value;
	TNode next;
	bool isLast = true;

	public TNode(){	} //constructs an empty node
	public TNode(string val) //constructs a node with the given value
	{
		setValue(val);
	}
	public TNode(string val, TNode nextNode) //constructs a node of the given value, linked to the given node
	{
		setValue(val);
		setNext(nextNode);
	}
	public TNode getNext() { if (isLast) return null; else return next;}
	public void setNext(TNode newNext) {next = newNext; setLast(false); }
	public string getValue()	{return value;	}
	public void setValue(string val){value = val;	}
	public void setLast(bool newState) {isLast = newState; }
	public bool getLast() { return this.isLast; }
	public void print()
	{
		Console.Write(this.getValue());
	}
}
