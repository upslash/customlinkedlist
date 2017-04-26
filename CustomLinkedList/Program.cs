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

            public Node Find(object data)
            {
                Node Current = Head;
                while(Current.Value != data)
                {
                    Current = Current.Next;
                    if(Current == null)
                    {
                        return null;
                    }
                }
                return Current;
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

            public void AddBefore(Object insert, Node beforeMe)
            {
                Node Current = Head;

                Node addMe = new Node();
                addMe.Value = insert;
                addMe.Next = beforeMe;

                // Check if there are any nodes beforeMe
                if(Current == beforeMe)
                {
                    addMe.Next = beforeMe;
                }
                else
                {
                    while (Current.Next != beforeMe)
                    {
                        Current = Current.Next;
                        if (Current.Next == beforeMe)
                        {
                            break;
                        }
                    }
                    Current.Next = addMe;
                }
            }

            public void AddAfter(Object insert, Node afterMe)
            {
                Node addMe = new Node();
                addMe.Value = insert;
                addMe.Next = afterMe.Next;
                afterMe.Next = addMe;
            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddFirst("Apple");
            list.AddFirst("Orange");
            list.AddLast("Bacon");
            list.AddFirst("Grape");
            list.AddFirst("Yam");
            list.PrintAllNotes();

            Console.WriteLine("Now we are going to add an item before Orange");
            Node addBeforeMe = list.Find("Orange");
            list.AddBefore("Banana", addBeforeMe);
            list.PrintAllNotes();

            Console.WriteLine("Now we are going to add an item after Bacon");
            Node addAfterMe = list.Find("Bacon");
            list.AddAfter("Strawberry", addAfterMe);
            list.PrintAllNotes();

            Console.ReadLine();
        }
    }
}
