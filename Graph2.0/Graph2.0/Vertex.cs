using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2._0
{
    public class Vertex // Узел графа
    {
        public int Value { get; set; }
        public Vertex(int value)
        {
            Value = value;
        }


        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
