using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class Program
    {
        public class Node
        {
            public object Value;
            public Node Next;
        }

        public class LinkedList
        {
            private Node Head;
            //private Node Tail;

            public void PrintAllNotes()
            {
                Node Current = Head;
                while (Current != null)
                {
                    Console.WriteLine(Current.Value);
                    Current = Current.Next;
                }
            }

            public void AddFirst(Object objectToAdd)
            {
                Node addMe = new Node();
                addMe.Value = objectToAdd;

                // Next is now equal to the current head
                addMe.Next = Head;

                // Head is now equal to this newly added node
                Head = addMe;
            }

            public void AddLast(Object objectToAdd)
            {
                if(Head == null)
                {
                    Head = new Node();
                    Head.Value = objectToAdd;
                }
                else
                {
                    Node addMe = new Node();
                    addMe.Value = objectToAdd;

                    Node Current = Head;
                    while (Current.Next != null)
                    {
                        Current = Current.Next;
                    }
                    Current.Next = addMe;
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Example app with custom Linked List implementation");
            LinkedList list = new LinkedList();
            list.AddFirst("Apple");
            list.AddFirst("Orange");
            list.AddLast("Bacon");
            list.PrintAllNotes();

            //LinkedList<string> list = new LinkedList<string>();
            //list.AddFirst("Apple");
            //list.AddFirst("Orange");
            //list.AddLast("Bacon");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}
