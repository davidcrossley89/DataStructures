using System;

public class TList
{
	public TNode head { get; set; }      //Simple List: only knows its own first node and count of nodes
	public int count { get; set; } = 0;
	public TList(TNode node) //Constructor, given a node
	{
		head = node;
		count++;
	}
	public TList(string node) //Constructor, given a string, it creates a new node
	{
		new TList(new TNode(node));
	}

	public void push(string nextNode) //add a single node to the front of a list.
	{
		TNode secondNode = this.head;
		
		TNode firstNode = new TNode(nextNode);
		head = firstNode;		
		head.addNext(secondNode);
		count++;
	}
	public string pop()  //returns the first node in the list, removes it from list
	{
		if (this.head == null){
			Console.WriteLine("Empty List");
			return "";
		}
		string ans;
		ans = head.data;
		this.remove(0);
		return ans;	
	}
	public void print()		//used to display all members of the list
	{
		if (head != null)
		{
			head.printAll();
		}
		else { Console.WriteLine("Empty List"); }
	}
	public void insert(int index, string addData) //insert a value at the given index

	{
		TNode node = new TNode(addData);
		if (this.head == null||count <=index) {
			Console.WriteLine("List does not contain the given index");
		}
		else if (index == 0)
		{
			node.addNext(this.head);
			count++;
			this.head = node;
		}
		else
		{
			head.insert(index-1, node);
			count++;
		}
	}

	public void remove(int index) //removes the given index from the list
	{

		if (this.head == null || count<=index)
		{
			Console.WriteLine("List does not contain the given index");
		}
		else if (index == 0) 
		{
			head = head.next;
			count = count - 1;
		}
		else
		{
			head.next.remove(index - 1, head);
			count = count - 1;
		}
	}
	public void clear()
	{
		head = null;
		count = 0;
	}
}
