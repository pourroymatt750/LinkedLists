// C#
public class Node
{
    public Node next;
    public int data;
}

public class LinkedList
{
    private Node head;

    public void printAllNodes()
    {
        Node curr = head;
        while (curr != null)
        {
            Console.WriteLine(curr.data);
            curr = curr.next;
        }
    }

    public void AddFirst(int data)
    {
        Node toAdd = new Node();

        toAdd.data = data;
        toAdd.next = head;

        head = toAdd;
    }

    public void AddLast(int data)
    {
        if (head == null)
        {
            head = new Node();

            head.data = data;
            head.next = null;
        }
        else
        {
            Node toAdd = new Node();
            toAdd.data = data;

            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = toAdd;
        }
    }

    public void RemoveInt(int data)
    {
        if (head == null) return;

        if (head.data == data)
        {
            head = head.next;
            return;
        }

        Node curr = head;
        while (curr.next != null)
        {
            if (curr.next.data == data)
            {
                curr.next = curr.next.next;
                return;
            }
            curr = curr.next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList myList = new LinkedList();
        myList.AddLast(1);
        myList.AddLast(2);
        myList.printAllNodes();
        Console.WriteLine("-----------------");
        myList.RemoveInt(1);
        myList.printAllNodes();
    }
}