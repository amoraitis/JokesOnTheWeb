using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesOnTheWeb.Models
{
    public class Joke
    {
        public string type { get; set; }
        public Value value { get; set; }

    }
    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
    }
}
