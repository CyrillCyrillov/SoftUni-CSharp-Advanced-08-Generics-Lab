using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        Stack<T> boxElements;

        public BoxOfT()
        {
            boxElements = new Stack<T>();

        }

        public void Add(T newElement)
        {
            boxElements.Push(newElement);
        }

        public T Remove()
        {
            T removedElement = boxElements.Pop();
            return removedElement;
        }

        public int Count { get { return boxElements.Count; } }
    }
}
