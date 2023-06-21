//// See https://aka.ms/new-console-template for more information


//using System;
//using System.Collections.Generic;


//namespace LinkedLists_assignment
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //creating a new linked list
//            //LinkedList li = new LinkedList();

//            ////Console.WriteLine("Is list is Empty : - " + li.Empty);
//            ////Console.WriteLine("Size of list is:- " + li.Count);

//            //li.Add("Test1");
//            //li.Add("Test2");
//            //li.Add(1, "Test3");

//            ////li.Print();

//            //int result = li.IndexOf("Test1");
//            //Console.WriteLine("Index = " + result);
//            //Console.WriteLine(li.Head());
//            //Console.ReadLine();


//            LinkedList list = new LinkedList();


//            list.Insert(1);
//            list.Insert(2);
//            list.Insert(3);

//            list.Print();


//            //li.InsertAtHead(head, 2);
//            //li.InsertAtHead(head, 3);
//            //li.InsertAtHead(head, 4);
//            //li.InsertAtHead(head, 5);

//            Console.ReadLine();
//        }
//    }
//}


using System;

namespace LinkedLists_assignment
{
    class Program {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            list.AddFirst(0);
            list.PrintAllItems();

            //int result = list.FirstIndexOf(3);
            //Console.WriteLine("IndexOf = " + result);

            list.RemoveLast();
            list.PrintAllItems();
            Console.ReadLine();
        }
        
    };
    

}