using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    public class todoManager
    {

        List<Todo> todos = new List<Todo>();

        public todoManager() { }

        public void Add(Todo todo)
        {
            todos.Add(todo);
        }

        public void Remove(Todo todo) 
        {
            todos.Remove(todo);
        }

        public void DisplayAll()
        {
            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Name}");
            }
        }
    
    }
}
