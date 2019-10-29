using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{  

    public class List
    {
        public Node Head { get; set; }

        public List()
        {
            Head = null;
        }

        public void AddNode(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = new Node(data);
            }
        }

        public void Display()
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                Console.Write(temp.Data + "-->");
                temp = temp.Next;
            }
            Console.Write(temp.Data + "\t");
        }

        public void Display(Node node)
        {
            while (node.Next != null)
            {
                Console.Write(node.Data + "-->");
                node = node.Next;
            }
            Console.Write(node.Data + "\t");
        }

        /// <summary>
        /// Reverses the linked list in iteration approach
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node ReverseLinkedList(Node node)
        {
            if (node == null || node.Next == null)
                return node;

            Node prev = null;
            Node current = node;

            while(current != null)
            {
                Node next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        /// <summary>
        /// Reverses the linked list using recursion 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node ReverseLinkedListRec(Node node)
        {
            if (node.Next == null)
                return node;
           
            Node prev = node;
            Node n = ReverseLinkedListRec(node.Next);
            node.Next.Next = prev;

            if (prev == Head)
                prev.Next = null;

            return n;
        }
    }
 }
