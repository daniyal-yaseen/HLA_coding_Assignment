﻿using System;

namespace Linklist
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Add First:");
                LinkedList myList1 = new LinkedList();

                myList1.AddFirst("Muhammad");
                myList1.AddFirst("Daniyal");
                myList1.AddFirst("Memon");
                myList1.printAllNodes();

                Console.WriteLine();

                Console.WriteLine("Add Last:");
                LinkedList myList2 = new LinkedList();

                myList2.AddLast("Muhammad");
                myList2.AddLast("Daniyal");
                myList2.AddLast("Memon");
                myList2.printAllNodes();

                Console.ReadLine();
            }
        }
    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }


}
