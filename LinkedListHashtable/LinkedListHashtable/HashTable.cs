﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHashtable
{
    class HashTable
    {
        public Node StartNode { get; private set; }

        Node[] hashtable = new Node[20];
        public void AddToTable(string data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = hashtable[FindHashValue(data)];
            hashtable[FindHashValue(data)] = newNode;

        }
        public int FindHashValue(string data)
        {
            int temp = data.Length;
            return temp;
        }
        public bool RemoveFromTable(string data)
        {
            Node ToRemove;
            Node Prev = hashtable[FindHashValue(data)];

            if (Prev.Data == data)
            {
                hashtable[FindHashValue(data)] = Prev.Next;
                Prev.Next = null;
                return true;
            }
            while (Prev != null)
            {
                if (Prev.Next.Data.Equals(data))
                {
                    ToRemove = Prev.Next;
                    Prev.Next = ToRemove.Next;
                    ToRemove.Next = null;
                    return true;
                }
                Prev = Prev.Next;
            }
            // Search for the data and delete it
            return false;
        }
        internal Node Exists(string data)
        {
            Node temp = hashtable[FindHashValue(data)];
            while (temp != null)
            {
                if (temp.Data.Equals(data))
                    return temp;
                temp = temp.Next;
            }
            return null;
        }
    }
}
