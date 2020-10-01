using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_API.Interfaces;
using To_Do_List_API.Models;
using System.Data.SqlClient;
using To_Do_List_API.Data;

namespace To_Do_List_API
{
    public class TodosImpl: ITodos
    {

        private TodosContext _context = new TodosContext();

        private List<Todo> todos;
        public List<Todo> get()
        {
            todos = new List<Todo>();

            todos = _context.Todos.Where(item => item.deleted == false).ToList<Todo>();

            return todos;
        }

        public Todo insert(Todo todo)
        {
            _context.Add(todo);

            _context.SaveChanges();

            return todo;
        }

        public void setCompleted(int id)
        {
            var todo = _context.Todos.Find(id);
            todo.completed = !todo.completed;

            _context.SaveChanges();
        }

        public void delete(int id)
        {
            var todo = _context.Todos.Find(id);
            todo.deleted = true;

            _context.SaveChanges();
        }
    }
}
