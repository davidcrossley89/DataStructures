using System;

public class TList
{
	//---------------Attributes--------------------------------------------------------

	private TNode head;     //Simple List: only knows it's own first node


	//---------------Constructors------------------------------------------------------
	public TList() { }  //Constructs an empty list
	public TList(TNode node) //Constructor, given a node
	{
		head = node;
	}
		public TList(string node) //Constructor, given a string, it creates a new node
	{
		head = new TNode(node);
	}


	//----------------------Methods---------------------------------------------------
	/// Push, pop, length, getLast, reverse, merge, print
	public int length()  //Returns the number of nodes in the list
	{
		if (head == null) { return 0; }
		else
		{
			TNode curNode = head;
			int ans = 1;
			while (curNode.getLast() == false)
			{
				ans += 1;
				curNode = curNode.getNext();
			}
			return ans;
		}
	}
	public void push(string newVal) //add a single node to the front of a list.
	{
		TNode newNext = head;		//pushes all other values back in list
		head = new TNode(newVal,newNext);
	}
	public string pop() //return the value of the first node in list
	{					//removes first value from list
		string ans = head.getValue();
		head = head.getNext();
		return ans;
	}
	
	public TNode getLast()  //returns the last node in the list
	{
		TNode curNode = head;
		while (curNode.getLast() == false)
			{
			curNode.print();
				curNode = curNode.getNext();
			}
			return curNode;
		}
	public TList reverse()  //copies the list into a new namespace in reverse order
	{
		TList newList = new TList(new TNode(this.head.getValue()));
		TNode curNode = this.head.getNext();
		while (curNode.getLast() == false)
		{
			newList.push(curNode.getValue());
			curNode = curNode.getNext();
		}
		newList.push(curNode.getValue());
		return newList;
	}

	public void merge(TList nextList) //Adds a list to the end of the current list
	{
		TNode endNode = getLast();
		endNode.setNext(nextList.getHead());
		getLast().setLast(true);
	}
	public void print()		//used to display all members of the list
	{
		TNode curNode = head;
		if (curNode != null)
		{
			while (curNode.getLast() == false)
			{
				curNode.print();
				curNode = curNode.getNext();
			}
			curNode.print();
		}
		Console.WriteLine("");
	}


	//////////////////////////////// Getters and Setters/////////////////////////////////////
	
	public void setHead(TNode newHead) { head = newHead; }
	public TNode getHead() { return head; }
}
