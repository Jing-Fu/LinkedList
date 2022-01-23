using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListNode
    {
        public int data;
        public ListNode nextNode = null;
        public ListNode(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        ListNode rootNode = null;

        public void Traverse()
        {
            if (rootNode == null)
            {
                return;
            }

            ListNode currentNode = rootNode;
            while (currentNode != null)
            {
                Console.WriteLine("currentNode data=" + currentNode.data);
                currentNode = currentNode.nextNode;
            }
        }

        public void PushBack(int value)
        {
            if (rootNode == null)
            {
                rootNode = new ListNode(value);
                return;
            }

            ListNode currentNode = rootNode;
            while (currentNode.nextNode != null)
            {
                currentNode = currentNode.nextNode;
            }
            currentNode.nextNode = new ListNode(value);
        }

        public void PushFront(int value)
        {
            ListNode node = new ListNode(value);
            if (rootNode != null)
            {
                node.nextNode = rootNode;
                rootNode = node;
            }
        }

        public void Delete(int value)
        {
            ListNode currentNode = rootNode;
            ListNode previousNode = null;
            if (rootNode == null)
            {
                return;
            }

            while (currentNode != null && currentNode.data != value)
            {
                previousNode = currentNode;
                currentNode = currentNode.nextNode;
            }

            if (currentNode == rootNode)
            {
                rootNode = currentNode.nextNode;
                currentNode = null;
            }
            else
            {
                previousNode.nextNode = currentNode.nextNode;
                currentNode = null;
            }
        }
    }
}