using System;

namespace Graph2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v4);
            graph.AddEdge(v2, v3);
            graph.AddEdge(v4, v3);
            graph.AddEdge(v4, v5);            

            //GetMatrix(graph);
            //Console.WriteLine();
            //GetVertex(graph, v1);
            //GetVertex(graph, v2);
            //GetVertex(graph, v3);
            //GetVertex(graph, v4);
            //GetVertex(graph, v5);

            graph.BFS(v1, v5);
            Console.WriteLine();
            graph.DFS(v1, v5);
        }

        private static void GetVertex(Graph graph, Vertex vertex) // Вывести на консоль узел и его смежные узлы
        {
            Console.Write(vertex.Value + ": ");
            foreach(var v in graph.GetVertexList(vertex))
            {
                Console.Write(v.Value + ", ");
            }
            Console.Write("\n");
        }

        private static void GetMatrix(Graph graph) //вывести на консоль матрицу смежности
        {
            var matrix = graph.Matrix();

            for (int i = 1; i < graph.VertexCount; i++)
            {
                for (int j = 1; j < graph.VertexCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
