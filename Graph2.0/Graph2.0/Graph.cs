using System;
using System.Collections;
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


        public void AddVertex(Vertex vertex) // Добавить узел в список узлов
        {
            Vertices.Add(vertex);
        }
        public void AddEdge(Vertex from, Vertex to) // Добавить связь в список ребер (связей)
        {
            var edge = new Edges(from, to);
            Edgess.Add(edge); 
        }


        public int[,] Matrix() // Матрица смежности
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

        public List<Vertex> GetVertexList(Vertex vertex) // Список узлов
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
       
        public bool BFS(Vertex start, Vertex finish) // Обход в ширину
        {
            Console.WriteLine("BFS");
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
        public bool DFS(Vertex start, Vertex finish) // Обход в глубину
        {
            Console.WriteLine("DFS");
            List<Vertex> visited = new List<Vertex>();

            Stack<Vertex> stack = new Stack<Vertex>();

            int step = 1;

            stack.Push(start);

            while(stack.Count > 0)
            {
                var vertex = stack.Pop();

                Console.WriteLine($"Шаг {step} - " + vertex);
                step++;

                if (!visited.Contains(vertex))
                {
                    visited.Add(vertex);
                    foreach (var v in GetVertexList(vertex))
                    {
                        stack.Push(v);
                    }
                }
            }
            return visited.Contains(finish);
        }

    }
}
    