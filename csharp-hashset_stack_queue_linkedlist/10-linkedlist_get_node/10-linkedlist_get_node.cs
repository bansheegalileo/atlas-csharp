using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= myLList.Count)
        {
            return 0;
        }

        LinkedListNode<int> node = myLList.First;
        for (int i = 0; i < n; i++)
        {
            node = node.Next;
        }

        return node.Value;
    }
}
