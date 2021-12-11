using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2._0
{
    internal class Graph
    {
        List<Vertex> Vertices = new List<Vertex>();
        List<Edges> Edgess = new List<Edges>();

        public int VertexCount => Vertices.Count;
        public int Edges => Edgess.Count;


        public void AddVertex(Vertex vertex)
        {
            Vertices.Add(vertex);
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edges(from, to);
            Edgess.Add(edge); 
        }


        public int[,] Matrix()
        {
            var matrix = new int[Vertices.Count, Vertices.Count];
            foreach(var edge in Edgess)
            {
                var line = edge.From.Value;
                var column = edge.To.Value;

                matrix[line, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexList(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach(var edge in Edgess)
            {
                if(edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }
       
        public bool BFS(Vertex start, Vertex finish)
        {
            int step = 1;

            var queue = new Queue<Vertex>();
            queue.Enqueue(start);

            Console.WriteLine($"Шаг {step} - " + start);

            for (int i = 0; i <= queue.Count; i++)
            {
                var vertex = queue.Dequeue();
                foreach (var v in GetVertexList(vertex))
                {
                    if (!queue.Contains(v))
                    {
                        queue.Enqueue(v);
                        step++;
                        Console.WriteLine($"Шаг {step} - " + v);
                    }
                }
            }

            return queue.Contains(finish);
        }
        public void DFS(Vertex start, Vertex finish) //на 11.12 не реализовано
        {
            int step = 1;

            var stack = new Stack<Vertex>();
            stack.Push(start);

            Console.WriteLine($"Шаг {step} - " + start);

            for (int i = 0; i <= stack.Count; i++)
            {
                var vertex = stack.Pop();
                foreach (var v in GetVertexList(vertex))
                {
                    if (!stack.Contains(v))
                    {
                        stack.Push(v);
                        step++;
                        Console.WriteLine($"Шаг {step} - " + v);
                    }
                }
            }
        }

    }
}
    