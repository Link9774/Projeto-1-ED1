class CircularLinkedList
{
    private Node head;
    private Node tail;

    public CircularLinkedList()
    {
        head = null;
        tail = null;
    }

    
    public void RemoveAt(int index)
{
    if (head == null || index < 0) 
    {
        Console.WriteLine("Índice fora do intervalo ou lista vazia.");
        return;
    }
    if (index == 0)
    {
        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.Next;
            tail.Next = head;
        }
        return;
    }

    Node current = head;
    int count = 0;

    do
    {
        if (count == index - 1)
        {
            if (current.Next == tail)
            {
                tail = current;
                tail.Next = head;
            }
            else
            {
                current.Next = current.Next.Next;
            }
            return;
        }

        current = current.Next;
        count++;
    } while (current != head);

    Console.WriteLine("Índice fora do intervalo.");
}
    
    public string GetAt(int index)
{
    if (head == null || index < 0) 
    {
        return null;
    }

    Node current = head;
    int count = 0;
    do
    {
        if (count == index)
        {
            return current.Data;
        }
        current = current.Next;
        count++;
    } while (current != head);

    return null;
}
    public void Add(string data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            tail.Next = head;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
        }
    }
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        Node current = head;
        do
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        } while (current != head);
    }
    public void Remove(string data)
    {
        if (head == null) return;

        if (head.Data == data)
        {
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                tail.Next = head;
            }
            return;
        }

        Node current = head;
        do
        {
            if (current.Next.Data == data)
            {
                if (current.Next == tail)
                {
                    tail = current;
                    tail.Next = head;
                }
                else
                {
                    current.Next = current.Next.Next;
                }
                return;
            }
            current = current.Next;
        } while (current != head);
    }

    public int Count()
    {
        if (head == null) return 0;

        Node current = head;
        int count = 0;
        do
        {
            count++;
            current = current.Next;
        } while (current != head);

        return count;
    }

    public void InsertAt(int index, string data)
    {
        Node newNode = new Node(data);

        if (index == 0)
        {
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                tail.Next = head;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                tail.Next = head;
            }
        }
        else
        {
            Node current = head;
            int count = 0;

            do
            {
                if (count == index - 1)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;

                    if (current == tail)
                    {
                        tail = newNode;
                    }
                    return;
                }
                current = current.Next;
                count++;
            } while (current != head);

            Console.WriteLine("Índice fora do intervalo.");
        }
    }
}