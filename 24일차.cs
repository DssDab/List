using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace _20250806
{
    class Program
    {
        static void Main(string[] args) 
        {
           LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            

            
            Node<int> node = list.AddLast(4);

            list.Remove(node);

            Console.WriteLine(list.count);

        }
    }
    class List<T>
    {
        private T[] arr = new T[1];
        private int count;
        public int Count { get { return count; } }

        public T this[int index]
        {
            get 
            {
                if(index < 0 || index >= arr.Length)
                    throw new IndexOutOfRangeException();

                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        public void Add(T item)
        {
            
            if (arr.Length <= count)
                Array.Resize(ref arr, count * 2);

            arr[count] = item;
            count++;
        }
        public void RemoveAt(int index)
        {
            T[] temp = new T[count-1];

            for(int i=0; i< temp.Length; i++)
            {
                temp[i] = arr[i < index ? index : i+1];
            }
            arr = temp;
            count--;
        }

    }
    class Node<T>
    {
        public T Data;

        public Node<T> prev;
        public Node<T> next;
    }

    class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;

        public int count = 0;

        public Node<T> AddLast(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            if (Head == null)
                Head = newNode;

            if(Tail != null)
            {
                Tail.next = newNode;
                newNode.prev = Tail;
            }
            Tail = newNode;
            count++;
            return newNode;
        }
        public void Remove(Node<T> node)
        {
            if(node == Head)
            {
                Head = Head.next;
            }
            if(node == Tail)
            {
                Tail = Tail.prev;
            }
            if(node.prev != null)
            {
                node.prev.next = node.next;
            }
            if(node.next != null)
            {
                node.next.prev = node.prev;
            }
            count--;
        }


    }
}
