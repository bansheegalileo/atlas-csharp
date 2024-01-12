using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;

        if (current == null || current.Value >= n)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }

        myLList.AddAfter(current, newNode);
        return newNode;
    }
}
