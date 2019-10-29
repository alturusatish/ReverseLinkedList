using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List list = new List();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(50);
            Console.WriteLine("\n Original linked list : \t");
            list.Display(list.Head);
            Console.WriteLine("\n Reverse linked list : \t");
            Node newHead = list.ReverseLinkedList(list.Head);
            list.Display(newHead);

            List list1 = new List();
            list1.AddNode(10);
            list1.AddNode(20);
            list1.AddNode(30);
            list1.AddNode(40);
            list1.AddNode(50);
            Console.WriteLine("\n Original linked list : \t");
            list1.Display(list1.Head);
            Console.WriteLine("\n Reverse linked list using recursion:");
            newHead = list1.ReverseLinkedListRec(list1.Head);
            list1.Display(newHead);
        }
    }
}
