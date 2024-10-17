class DoubleNode
{
    public string Data;
    public DoubleNode Next;
    public DoubleNode Previous;

    public DoubleNode(string data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}
class DoubleLinkedList
{
    private DoubleNode head;
    private DoubleNode tail;

    public void Add(string data)
    {
    DoubleNode newNode = new DoubleNode(data);
    if (head == null)
        {
            head = newNode;
            tail = newNode;
        }else{
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
            }
    }
public void Remove(string data)
{
    if(head == null) return;

    DoubleNode current = head;

    while(current != null)
    {
       if(current.Data == data)
       {
            if(current == head)
            {
                head = current.Next;
                if(head != null) head.Previous = null;
            }
            else if(current == tail)
            {
                tail = current.Previous;
                tail.Next = null;
            }else{
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                }
                break;
       } 
        current = current.Next;
    }
}

public void RemoveAt(int index)
{
    if(head == null) return;

    DoubleNode current = head;
    int count = 0;
     while (current != null)
        {
            if (count == index)
            {
                if (current == head)
                {
                    head = current.Next;
                    if (head != null) head.Previous = null;
                }
                else if (current == tail)
                {
                    tail = current.Previous;
                    if (tail != null) tail.Next = null;
                }
                else
                {
                    current.Previous.Next = current.Next;
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                }
                return;
            }
            current = current.Next;
            count++;
        }
}
public void Clear()
{
    head = null;
    tail = null;
}



public void DisplayDireita()
{
    DoubleNode current = head;
    while (current != null)
    {
        Console.WriteLine(current.Data);
        current = current.Next;
    }
}
public void DisplayEsquerda()
{
    DoubleNode current = tail;
    while (current != null)
    {
        Console.WriteLine(current.Data);
        current = current.Previous;
    }

}
public int IndexOf(string data)
{
    DoubleNode current = head;
    int index = 0;
    while (current != null)
    {
        if (current.Data == data)
        
            return index;
                current = current.Next;
                index++;
        }
        return -1;
    }
    public string GetAt(int index)
    {
        DoubleNode current = head;
        int count = 0;
        while(current != null)
        {
            if(count == index)
                return current.Data;
            current = current.Next;
            count++;
        }
        return null;
    }   
    
    public int Count()
    {
        DoubleNode current = head;
        int count = 0;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
    public void ReplaceAt(int index, string newData)
    {
        DoubleNode current = head;
        int count = 0;
        while (current != null)
        {
            if(count == index)
            {
                current.Data = newData;
                return;
            }
            current = current.Next;
            count++;
        }
    }

}

    



