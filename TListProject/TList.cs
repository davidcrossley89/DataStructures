using System;

public class TList
{
	//---------------Attributes--------------------------------------------------------

	private TNode head;     //Simple List: only knows it's own first node
	private bool isEmpty;


	//---------------Constructors------------------------------------------------------
	public TList()
	{   //Constructs an empty list
		this.setEmpty(true);
	}
	public TList(TNode node) //Constructor, given a node
	{
		head = node;
		setEmpty(false);
	}
	public TList(string node) //Constructor, given a string, it creates a new node
	{
		head = new TNode(node);
		setEmpty(false);
	}


	//----------------------Methods---------------------------------------------------
	/// Push, pop, length, getLast, reverse, merge, print
	public int length()  //Returns the number of nodes in the list
	{
		if (getEmpty())
		{
			return 0;
		}
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
		if (getEmpty())
		{
			setHead(new TNode(newVal));
			setEmpty(false);
		}
		else
		{
			TNode newNext = head;       //pushes all other values back in list
			head = new TNode(newVal, newNext);
		}
	}
	public string pop() //return the value of the first node in list
	{                   //removes first value from list
		if (getEmpty()) { return null; }
		else
		{
			string ans = head.getValue();
			head = head.getNext();
			return ans;
		}
	}
	
	public TNode getLast()  //returns the last node in the list
	{
		if (getEmpty()) { return null; }
		else
		{

			TNode curNode = head;
			while (curNode.getLast() == false)
			{
				curNode = curNode.getNext();
			}
			return curNode;
		}
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
	public bool getEmpty() { return isEmpty;}
	public void setEmpty(bool newEmpty) { isEmpty = newEmpty; }
}
