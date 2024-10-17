//Projeto-1


class Node
{
    public string Data;
    public Node Next;

    public Node(string data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void Add(string data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Remove(string data)
    {
        if (head == null) return;

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Data != data)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public int IndexOf(string data)
    {
        Node current = head;
        int index = 0;
        while (current != null)
        {
            if (current.Data == data) return index;
            current = current.Next;
            index++;
        }
        return -1;
    }

    public string GetAt(int index)
    {
        Node current = head;
        int count = 0;
        while (current != null)
        {
            if (count == index) return current.Data;
            current = current.Next;
            count++;
        }
        return null;
    }

    public int Count(){
    
        Node current = head;
        int count = 0;
        while (current != null){
        
            count++;
            current = current.Next;
        }
        return count;
    }
    public void ReplaceAt(int index, string newData){
        if(head == null){
            return;
        }
        Node current = head;
        int count = 0;

        while (current != null){
            if (count == index){
                current.Data = newData;
                return;
            }
            current = current.Next;
            count++;
        }
    }

}