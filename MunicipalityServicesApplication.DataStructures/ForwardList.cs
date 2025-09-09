namespace MunicipalityServicesApplication.DataStructures
{
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

        public void AddLast(T item)
        {
            var n = new Node(item);
            if (_head is null) _head = _tail = n;
            else { _tail!.Next = n; _tail = n; }
            _count++;
        }

        public void ForEach(Action<T> action)
        {
            var n = _head;
            while (n != null) { action(n.Value); n = n.Next; }
        }
    }
}
