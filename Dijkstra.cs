using BinarySearchTree;
using PriorityQueue_우선순위큐;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250806
{
    class Graph
    {
        int[,] map = new int[8, 8]
        {
            { -1, 10, -1, 18, -1, -1, -1, -1 },
            { 10, -1, 05, 06, -1, -1, -1, -1 },
            { -1, 05, -1, -1, -1, -1, -1, -1 },
            { 18, 06, -1, -1, 13, -1, -1, -1 },
            { -1, -1, -1, 13, -1, 14, 08, -1 },
            { -1, -1, -1, -1, 14, -1, -1, 17 },
            { -1, -1, -1, -1, 08, -1, -1, 26 },
            { -1, -1, -1, -1, -1, 17, 26, -1 },
        };

        bool[] visited = new bool[8];
        int[] distance = new int[8];
        int[] parent = new int[8];
        public void Dijkstra(int start)
        {
            Array.Fill(distance, Int32.MaxValue);
            distance[start] = 0;
            parent[start] = start;
            while (true)
            {
                // 제일 좋은 후보 찾기 (최단 거리 후보)

                // 가장 유력한 후보의 거리와 번호를 저장
                int closet = Int32.MaxValue;
                int now = -1;
                for (int i = 0; i < 8; i++)
                {
                    // 이미 방문한 정점은 스킵
                    if (visited[i] == true)
                        continue;

                    // 아직 발견된 적이 없거나, 기존 후보보다 멀면 스킵
                    if (distance[i] == Int32.MaxValue ||
                        distance[i] >= closet)
                        continue;

                    // 발견한 후보중 가장 좋은 후보를 찾음, 정보를 갱신
                    closet = distance[i];
                    now = i;

                }
                if (now == -1)
                    break;

                // 제일 좋은 후보 방문
                visited[now] = true;

                // 방문한 정점의 인접점 확인해서 최단거리를 갱신한다
                for (int next = 0; next < 8; next++)
                {
                    // 연결이 되어있지 않으면 스킵
                    if (map[now, next] == -1)
                        continue;
                    // 이미 방문한 정점도 스킵
                    if (visited[next] == true)
                        continue;

                    // 새로 조사된 인접 정점의 최단거리 계산
                    int nextDist = distance[now] + map[now, next];
                    // 위의 인접 정점의 최단거리를 갱신
                    if (nextDist < distance[next])
                    {
                        distance[next] = nextDist;
                        parent[next] = now;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.Dijkstra(0);

            var bst = new BinarySearchTree.BinarySearchTree();

            int[] items = { 3,5,4,2,1,9,7,6,0 };
            
            foreach(int item in items)
            {
                bst.Insert(item);
            }

            var findNow = bst.Find(6);

            Console.WriteLine($" 본노드 : {findNow.key} 좌노드 : {findNow.left}, 우노드 : {findNow.right} ");

            PriorityQueue<Knight> q = new PriorityQueue<Knight>();
            q.Push(new Knight() { id = 20});
            q.Push(new Knight() { id = 10 });
            q.Push(new Knight() { id = 30 });
            q.Push(new Knight() { id = 90 });
            q.Push(new Knight() { id = 40 });

            while (q.Count() > 0)
            {
                Console.WriteLine(q.Pop().id);
            }

        }
    }
    
}
namespace BinarySearchTree
{
    class BSTNode
    {
        public int key;
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int key)
        {
            this.key = key;
        }
    }

    class BinarySearchTree
    {
        private BSTNode _root;
        // Insert 까지 구현
        public void Insert(int key)
        {
            _root = InsertRec(_root, key);
        }
        private BSTNode InsertRec(BSTNode node, int key)
        {
            if (node == null)
                return new BSTNode(key);

            if (key < node.key)
                node.left = InsertRec(node.left, key);

            if (key > node.key)
                node.right = InsertRec(node.right, key);

            return node;
        }
        public BSTNode Find(int key)
        {
            var now = _root;
            while (now != null)
            {
                if (key == now.key)
                    return now;

                now = (key < now.key) ? now.left : now.right;
            }
            return null;
        }
        public bool Contains(int key)
        {
            var now = _root;
            while (now != null)
            {
                if (key == now.key)
                    return true;

                now = (key < now.key) ? now.left : now.right;
            }
            return false;
        }
        public void Remove(int key)
        {
            _root = RemoveRec(_root, key);
        }
        private BSTNode RemoveRec(BSTNode node, int key)
        {
            // 삭제하려는 노드가 널일 때
            if (node == null)
                return null;
            // 삭제하려는 키가 현재 노드보다 작다면
            if (key < node.key)
            {
                node.left = RemoveRec(node.left, key);
            }
            // 삭제하려는 키가 현재 노드보다 크다면
            else if (key > node.key)
            {
                node.right = RemoveRec(node.right, key);
            }
            else
            {
                // 해당 노드가 리프일 때
                if (node.left == null && node.right == null)
                    return null;

                // 해당 노드의 자식이 한 개일 때
                if (node.left == null)
                    return node.right;
                if (node.right == null)
                    return node.left;

                BSTNode min = FindMin(node.right);
                node.key = min.key;
                node.right = RemoveRec(node.right, min.key);
            }
            return node;
        }
        private BSTNode FindMin(BSTNode node)
        {
            while (node.left != null)
                node = node.left;

            return node;
        }

    }
}

// 자기 균형 이진 탐색 트리(self Balancing BST)
// AVL(DB) -> Red Black Tree
// AVL => 빡세게 균형잡는것
// RedBlack tree : 자기 균형 이진 탐색 트리
// 아이디어 : 빨강 또는 검정 이라는 색이라는 개념을 도입하여 규칙을 생성함
// - 모든 노드는 빨강 또는 검정이다.
// - 루트는 항상 검정이다.
// - 모든 리프(NIL 노드)는 검정이다.
// - NIL은 NULL
// - 빨간 노드의 자식은 항상 검정이다.
// - 루트에서 어떤 리프까지 가는 모든 경로에 있는 검정 노드 개수는 동일하다.

// 힙트리 - 힙정렬 - 우선순위큐 - 에이스타
namespace PriorityQueue_우선순위큐
{
    class PriorityQueue<T> where T : IComparable<T> 
    {
        List<T> _heap =  new List<T>();

        public void Push(T data)
        {
            _heap.Add(data);

            int now = _heap.Count - 1;
            while(now > 0)
            {
                int next = (now - 1) / 2;

                if (_heap[now].CompareTo(_heap[next]) < 0 )
                    break;

                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;
            }

        }
        public T Pop()
        {
            T ret = _heap[0];

            int lastIndex = _heap.Count - 1;
            _heap[0] = _heap[lastIndex];
            _heap.RemoveAt(lastIndex);
            lastIndex--;

            int now = 0;
            while (true)
            {
                int left = 2 * now + 1;
                int right = 2 * now + 2;

                int next = now;

                if (left <= lastIndex && _heap[next].CompareTo(_heap[left]) < 0)
                    next = left; 

                if(right <=lastIndex && _heap[next].CompareTo(_heap[right]) < 0)
                    next = right;

                if (next == now)
                    break;

                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;
            }

            return ret;

        }
        public int Count()
        {
            return _heap.Count;
        }

    }
    class Knight : IComparable<Knight>
    {
        public int id { get; set; }

        public int CompareTo(Knight? other)
        {
            if (id == other.id)
                return 0;

            return id > other.id ? 1 : -1;
        }
    }
}
