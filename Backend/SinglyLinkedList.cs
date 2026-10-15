namespace Backend;

public class SinglyLinkendList<T>
{
    private Node<T>? _head;

    public SinglyLinkendList()
    {
        _head = null;
    }

    // 1. Insert at the beginning
    public bool InsertAtBeginning(T data)
    {
        if (IsDuplicate(data)) return false;

        var newNode = new Node<T>(data);
        newNode.Next = _head;
        _head = newNode;
        return true;
    }

    // 2. Inset at the end
    public bool InsertAtEnd(T data)
    {
        if (IsDuplicate(data)) return false;

        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            return true;
        }
        var current = _head;
        while (current.Next != null)
            current = current.Next;

        current.Next = newNode;
        return true;
    }

    // 3. Search for an item
    public bool Contains(T data)
    {
        var current = _head;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, data))
                return true;

            current = current.Next;
        }

        return false;
    }

    // 4. Delete an Item
    public bool Remove(T data)
    {
        if (_head == null) return false;

        if (EqualityComparer<T>.Default.Equals(_head.Data, data))
        {
            _head = _head.Next;
            return true;
        }

        var current = _head;

        while (current.Next != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Next.Data, data))
            {
                current.Next = current.Next.Next;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    // 5. Reverse the list
    public void Reverse()
    {
        Node<T>? previous = null;
        var current = _head;

        while (current != null)
        {
            var next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        _head = previous;
    }

    // 6. Insert afte an existing element
    public bool InsertAfter(T previousData, T newData)
    {
        var current = _head;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, previousData))
            {
                var newNode = new Node<T>(newData);
                newNode.Next = current.Next;
                current.Next = newNode;
                return true;
            }

            current = current.Next;
        }
        return false;
    }

    // 7. Sort alphabetically
    public void Order()
    {
        if (typeof(T) != typeof(string))
            throw new InvalidOperationException("This operation requires a string list.");

        var values = new List<string>();
        var current = _head;

        while (current != null)
        {
            values.Add((string)(object)current.Data!);
            current = current.Next;
        }

        values.Sort(StringComparer.CurrentCultureIgnoreCase);

        _head = null;

        foreach (var value in values)
            InsertAtEnd((T)(object)value);
    }
    // 8. Show the list
    public override string ToString()
    {
        var output = string.Empty;
        var current = _head;
        while (current != null)
        {
            output += $"{current.Data} -> ";
            current = current.Next;
        }
        return $"{output} null";
    }

    private bool IsDuplicate(T data) => Contains(data);
}
