using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Graph
    {
        int[] deltaY = { -1, 0, 1, 0 };
        int[] deltaX = { 0, -1, 0, 1 };

        //int[,] map =
        //    {
        //    {0,1,0,1,0,0 },
        //    {1,1,1,0,0,0 },
        //    {0,1,0,0,0,0 },
        //    {1,1,0,0,1,0 },
        //    {0,0,0,1,0,1 },
        //    {0,0,0,0,1,0}
        //};
        public int[,] visited;
        public int[] distance;
        //public void BFS(int start)
        //{
        //    // 예약목록 만들기
        //    Queue<int> queue = new Queue<int>();

        //    // 예약 목록에 예약하기
        //    queue.Enqueue(start);
        //    visited[start] = true;
        //    distance[start] = 0;
         
        //    // 예약목록에서 예약을 꺼내서 아직 예약
        //    // 안했고 연결되어있고 방문안한 애들 예약하기
        //    while (queue.Count > 0) 
        //    {
        //        int now = queue.Dequeue();
        //        Console.WriteLine($"방문 횟수 : {now}");
                
        //        for (int next = 0; next < 4; next++) 
        //        {
        //            // Y,X는 내 위치
        //            //int nextY = Y + deltaY[next];
        //            //int nextX = X + deltaX[next];

        //            // 범위초과 확인
        //            //if (nextY < 0 || nextY >= map.GetLength(0) || nextX < 0 || nextX >= map.GetLength(1))
        //            //{
        //            //    continue;
        //            //}
        //            // 연결이 되어있는지
        //            if (map[now, next] == 0)
        //                continue;
        //            // 방문이 되어있는지
        //            if (visited[next] == true)
        //                continue;

        //            // 예약하기
        //            queue.Enqueue(next);
        //            visited[next] = true;
        //            distance[next] = distance[now] + 1;
        //        }
        //    }
        //    Console.WriteLine(distance[map.GetLength(0)-1]);
        //}
        public void BFS(int[,] map, int start)
        {
            visited = new int[map.GetLength(0), map.GetLength(1)];
           

            // 예약목록 만들기
            Queue<(int, int)> queue = new Queue<(int,int)>();

            // 예약 목록에 예약하기
            visited[start,start] = 1;
            queue.Enqueue((start,start));
            // 예약목록에서 예약을 꺼내서 아직 예약
            // 안했고 연결되어있고 방문안한 애들 예약하기
            while (queue.Count > 0)
            {
                (int Y,int X) = queue.Dequeue();
                for (int next = 0; next < 4; next++)
                {
                    // Y,X는 내 위치
                    int nextY = Y + deltaY[next];
                    int nextX = X + deltaX[next];

                    // 범위초과 확인
                    if (nextY < 0 || nextY >= map.GetLength(0) || nextX < 0 || nextX >= map.GetLength(1))
                    {
                        continue;
                    }
                    // 연결이 되어있는지
                    if (map[nextY, nextX] == 0)
                        continue;
                    // 방문이 되어있는지
                    if (visited[nextY, nextX] > 0)
                        continue;

                    // 예약하기
                    queue.Enqueue((nextY, nextX));
                    // 방문처리
                    visited[nextY, nextX] = visited[Y,X]+1;
                }
            }
            Console.WriteLine(visited[map.GetLength(0)-1,map.GetLength(1)-1]);
            
        }


    }
    class Program
    {
        static void Main()
        {
            Graph graph = new Graph();
            

            int n, m;
            int[,] map;
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            map = new int[n, m];

            for(int i=0; i < n; i++)
            {
                string line = Console.ReadLine();
                for(int j =0; j < m; j++)
                {
                    map[i, j] = line[j]-'0';
                }
            }
            graph.BFS(map, 0);
        }
    }
    
}
