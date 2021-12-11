﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2._0
{
    internal class Edges // Ребро графа
    {
        public Vertex From { get; set; }    
        public Vertex To { get; set; }
        public int Weight { get; set;}
        public Edges(Vertex from, Vertex to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"({From} {To})";
        }
    }
}
