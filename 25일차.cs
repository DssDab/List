using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250806
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        //int x = 10;
    //        //int y = 20;
    //        //Swap(ref x, ref y);

    //        //Console.WriteLine(x);
    //        //Console.WriteLine(y);

    //        //Console.WriteLine(solution(580010));

    //        //int[] arr = new int[] { 13, 15, 1, 50, 99 };
    //        //MinMax(arr);

    //        //CountingStar(Console.ReadLine());
    //        //Swap();
    //        //Add(1, 1);
    //        //Console.WriteLine(solution("hello", 3));
    //        //Console.WriteLine(solution("BCBdbe","B"));
    //        //Console.WriteLine(solution(7,15));
    //        //int[] arr = {1,2,3,4,5 ,5};
    //        //Console.WriteLine(solution(arr));
    //        //Console.WriteLine(solution(930211));
    //        //int[] date1 = { 2021, 12, 28 };
    //        //int[] date2 = { 2021, 12, 29 };
    //        //Console.WriteLine(solution(date1,date2));

    //        List<int> list = new List<int>();
    //        list.Add(1);
    //        list.Add(2);
    //        list.Add(3);

          
    //        list.RemoveAt(2);

    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            Console.WriteLine(list[i]);
    //        }
    //    }
    //    public static int solution(int[] date1, int[] date2)
    //    {
    //        int answer = 0;
    //        if (date1[0] <= date2[0])
    //        {
    //            if (date1[1] < date2[1])
    //            {
    //                if (date1[2] < date2[2])
    //                    answer = 1;
    //                else
    //                    answer = 0;
    //            }
    //            else
    //                answer = 0;
    //        }

    //        return answer;
    //    }
    //    static void Swap(ref int x, ref int y)
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;
    //    }
    //    static int GCD(int a, int b)
    //    {
    //        while (b != 0)
    //        {
    //            int temp = b;
    //            b = a % b;
    //            a = temp;
    //        }
    //        return a;
    //    }
    //    //static int solution(int n)
    //    //{
    //    //    int answer = 0;
    //    //    answer = n % 6 == 0 ? (n / 6) : (n*6 / GCD(n,6))/6;
    //    //    return answer;
    //    //}
    //    //static int solution(int slice, int n)
    //    //{
    //    //    int answer = 0;
    //    //    answer = n % slice == 0 ? n/ slice : n / slice + 1 ;
    //    //    return answer;
    //    //}
    //    //static int solution(int price)
    //    //{
    //    //    int answer = 0;

    //    //    if (price >= 100000 && price < 300000)
    //    //        answer = (int)(price * 0.95);
    //    //    else if (price >= 300000 && price < 500000)
    //    //        answer = (int)(price * 0.9);
    //    //    else if (price >= 500000)
    //    //        answer = (int)(price * 0.8);
    //    //    else
    //    //        answer = price;
    //    //    return answer;
    //    //}
    //    //static string solution(string my_string, int n)
    //    //{
    //    //    string answer = "";
            
    //    //    for(int i=0; i < my_string.Length; i++)
    //    //    {
    //    //        for(int j=0; j<n; j++)
    //    //        {
    //    //            answer += my_string[i];
    //    //        }
    //    //    }
    //    //    return answer;
    //    //}
    //    //public static string solution(string my_string, string letter)
    //    //{
    //    //    string answer = "";
    //    //    for(int i=0; i < my_string.Length; i++)
    //    //    {
    //    //        if (my_string[i] == letter[0])
    //    //            continue;
    //    //        answer += my_string[i];
    //    //    }
    //    //    return answer;
    //    //}
    //    //public static int solution(int n, int t)
    //    //{
    //    //    int answer = 0;
    //    //    answer = n * (int)Math.Pow(2, t);
    //    //    return answer;
    //    //}
    //    //public static int solution(int[] numbers)
    //    //{
    //    //    int answer =0;
    //    //    for(int i=0; i< numbers.Length;i++)
    //    //    {
    //    //        for(int j =i+1; j < numbers.Length; j++)
    //    //        {
    //    //            int product = numbers[i] * numbers[j];
    //    //            if(product > answer)
    //    //                answer = product;
    //    //        }
    //    //    }
         
    //    //    return answer;
    //    //}
    //    //public static int solution(int n)
    //    //{
    //    //    int answer = 0;
            
    //    //    while(n > 0)
    //    //    {
    //    //        answer += n % 10;
    //    //        n /= 10;
    //    //    }


    //    //    return answer;
    //    //}
    //    static void MinMax(int[] arr)
    //    {
    //        int min, max;

    //        min = arr[0];

    //        max = arr[arr.Length - 1];

    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            if (min > arr[i])
    //                min = arr[i];
    //            if (max < arr[i])
    //                max = arr[i];
    //        }
    //        Console.WriteLine(min);
    //        Console.WriteLine(max);
    //    }
    //    static int[] CountingStar(string s)
    //    {
    //        int[] str = new int[26];

    //        for(int i=0; i < s.Length; i++)
    //        {
    //            str[s[i] - 'a']++;
    //        }

    //        foreach(int i in str)
    //        {
    //            Console.Write(i+" ");
    //        }

    //        return str;
    //    }
    //    static void Swap()
    //    {
    //        int[,] arr = new int[,]
    //        {
    //            {1,2,3 },
    //            {4,5,6 },
    //            {7,8,9 },
    //        };
           
    //        for(int i = 0; i < arr.GetLength(0); i++)
    //        {
    //            for(int j=0; j<arr.GetLength(1); j++)
    //            {
    //                Console.Write(arr[j,i]);
    //            }
    //            Console.WriteLine();
    //        }
    //    }

    //    static void Add(int y, int x)
    //    {
    //        int[] dy = { -1, 0, 1, 0 };
    //        int[] dx = { 0, 1, 0, -1 };
    //        int[,] map =
    //        {
    //            {1,1,1 },
    //            {1,1,1 },
    //            {1,1,1 }
    //        };
    //        for (int i = 0;i<4; i++)
    //        {
    //            int ny = y + dy[i];
    //            int nx = x + dx[i];
    //            if (ny < 0 || ny >= map.GetLength(0) || nx < 0 || nx >= map.GetLength(1))
    //                continue;
    //            map[ny, nx]++;
    //        }
    //    }
    //}
}
class List<T>
{
    T[] arr = new T[1];
    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            if(index <0 || index >=arr.Length)
                throw new IndexOutOfRangeException();

            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    } 

    public void Add(T value)
    {
        if(arr.Length <= Count)
        {
            Array.Resize(ref arr, Count * 2);
            arr[Count] = value;
        }

        arr[Count] = value;
        Count++;
    }
    public void RemoveAt(int index)
    {
        T[] temp = new T[Count - 1];

        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = arr[i < index ? i : i+1];
        }
        arr = temp;
        Count--;
        
    }
}
class Node<T>
{
    public T Data;
    public Node<T> prev;
    public Node<T> next;
}
class myLinkedList<T>
{
  
    public Node<T> Head = null;
    public Node<T> Tail = null;
    public int Count { get; private set; } 

    public Node<T> AddLast(T item)
    {
        Node<T> newNode = new Node<T>();
        newNode.Data = item;

        if (Head == null)
        {
            Head = newNode;
        }

        if (Tail != null)
        {
            Tail.next = newNode;
            newNode.prev = Tail;
        }
        Tail = newNode;
        Count++;
        return newNode;
    }

    public void Remove(Node<T> node)
    {
        if (node == Head)
            Head = Head.next;
        if(node == Tail)
            Tail = Tail.prev;

        if (node.prev != null)
            node.prev.next = node.next;
        if (node.next != null)
            node.next.prev = node.prev;

        Count--;

    }
}
