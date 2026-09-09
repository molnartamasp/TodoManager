using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class Todo
    {

        public string Name { get; set; } = String.Empty;

        public int Hours { get; set; }

        public int Priority { get; set; }

        public Todo() { string name, int hours, int priority }

    }
}
