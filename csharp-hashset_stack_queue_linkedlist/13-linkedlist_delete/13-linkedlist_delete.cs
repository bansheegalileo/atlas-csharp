using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || index < 0)
        {
            return;
        }

        LinkedListNode<int> current = myLList.First;

        for (int i = 0; i < index && current != null; i++)
        {
            current = current.Next;
        }

        if (current != null)
        {
            myLList.Remove(current);
        }
    }
}
