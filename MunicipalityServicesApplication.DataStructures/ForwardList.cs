namespace MunicipalityServicesApplication.DataStructures
{
    /// <summary>
    /// A minimal singly linked list used as the core storage structure to satisfy the custom data structure requirement.
    /// </summary>
    public sealed class ForwardList<T>
    {
        private sealed class Node
        {
            public T Value;
            public Node? Next;
            public Node(T value) { Value = value; }
        }

        private Node? _head;
        private Node? _tail;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _count == 0;

        /// <summary>
        /// Appends an item to the end of the list in O(1).
        /// </summary>
        public void AddLast(T item)
        {
            var n = new Node(item);
            if (_head is null) _head = _tail = n;
            else { _tail!.Next = n; _tail = n; }
            _count++;
        }

        /// <summary>
        /// Iterates all items without exposing arrays or built-in collections.
        /// </summary>
        public void ForEach(Action<T> action)
        {
            var n = _head;
            while (n != null) { action(n.Value); n = n.Next; }
        }
    }
}
