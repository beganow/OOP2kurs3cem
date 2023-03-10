using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Bench
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Bench()
        {
            Name = "Bench";
        }

        public Bench(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"(It's a {GetType()} name - {Name} cost - {Cost})";
        }
    }
}
