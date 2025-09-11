using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250806
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(solution(580010));

            int[] arr = new int[] { 13, 15, 1, 50, 99 };
            MinMax(arr);

            CountingStar(Console.ReadLine());
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        //static int solution(int n)
        //{
        //    int answer = 0;
        //    answer = n % 6 == 0 ? (n / 6) : (n*6 / GCD(n,6))/6;
        //    return answer;
        //}
        //static int solution(int slice, int n)
        //{
        //    int answer = 0;
        //    answer = n % slice == 0 ? n/ slice : n / slice + 1 ;
        //    return answer;
        //}
        static int solution(int price)
        {
            int answer = 0;

            if (price >= 100000 && price < 300000)
                answer = (int)(price * 0.95);
            else if (price >= 300000 && price < 500000)
                answer = (int)(price * 0.9);
            else if (price >= 500000)
                answer = (int)(price * 0.8);
            else
                answer = price;
            return answer;
        }
        static void MinMax(int[] arr)
        {
            int min, max;

            min = arr[0];

            max = arr[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        static int[] CountingStar(string s)
        {
            int[] str = new int[26];

            for(int i=0; i < s.Length; i++)
            {
                str[s[i] - 'a']++;
            }

            foreach(int i in str)
            {
                Console.Write(i+" ");
            }

            return str;
        }
    }
}
