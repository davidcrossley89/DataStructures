using System;

public class TNode
{
	string value;
	TNode next;
	bool isLast = true;

	public TNode()
	{
		this.print();
	}
	public TNode(string val)
	{
		this.setValue(val);
	}
	public TNode getNext() { if (isLast) return null; else return this.next;}
	public void setNext(TNode newNext) {this.next = newNext; setLast(false); }
	public string getValue()	{return this.value;	}
	public void setValue(string val){this.value = val;	}
	public void setLast(bool newState) { this.isLast = newState; }
	public bool getLast() { return this.isLast; }
	public void print()
	{
		Console.Write(this.getValue());
	}
}
