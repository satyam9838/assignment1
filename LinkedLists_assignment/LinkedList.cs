using System;
namespace LinkedLists_assignment
{
    public class Node<T> where T : notnull
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<T> where T : notnull
    {
        private Node<T>? head;
        private int length;

        /// <summary>
        /// It should add element at the end of the Linked List
        /// </summary>
        /// <param name="data">Passing New Node data so that it should attah to existing linked list</param>
        public void AddLast(T data)
        {
            //list is empty
            if (head == null)
            {
                head = new Node<T>(data);
            }
            else
            {
                //adding the data at the end
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data);
            }
            length++;
        }

        /// <summary>
        /// Printing Elements one by one from the list
        /// </summary>
        public void PrintAllItems()
        {
            Node<T>? temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        /// <summary>
        /// Will remove the  last element from the list
        /// </summary>
        /// <returns> Node to be deleted </returns>
        /// <exception cref="InvalidOperationException"> Throws error if linked list is already empty</exception>
        public Node<T> RemoveLast()
        {
            //list is empty
            if (head == null)
            {
                throw new InvalidOperationException("LinkedList is empty.");
            }

            Node<T> nodeToBeDeleted;

            if (length == 1)
            {
                nodeToBeDeleted = head;
                head = null;
                length = 0;
                
                return nodeToBeDeleted;
            }

            Node<T> current = head;

            //traversing to the last element
            while (current.Next?.Next != null)
            {
                current = current.Next;
            }

            nodeToBeDeleted = current.Next!;
            current.Next = null;
            length--;
            return nodeToBeDeleted;
        }

        /// <summary>
        /// Removing all elements in the list
        /// </summary>
        public void Clear()
        {
            head = null;
            length = 0;
        }

        /// <summary>
        /// Will give length of Linked List
        /// </summary>
        /// <returns>How many items present</returns>
        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// It will add Element at the head of the Linked List
        /// </summary>
        /// <param name="data"></param>
        public void AddFirst(T data)
        {
            //creating a new node assigning that data to it
            Node<T> newNode = new Node<T>(data);
            //linking with the head
            newNode.Next = head;
            head = newNode;
            length++;
        }

        /// <summary>
        /// Will find index of the item present in linked List
        /// </summary>
        /// <param name="d"></param>
        /// <returns>Position of the item if present</returns>
        public int FirstIndexOf(T d)
        {
            if (head == null)
            {
                return -1;
            }

            Node<T> temp = head;
            int index = 0;

            while (temp.Next != null)
            { 
                if (temp.Data.Equals(d))
                {
                    return index;
                }

                temp = temp.Next;
                index++;
            }

            return -1;
        }
    }
}

