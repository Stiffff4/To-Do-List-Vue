using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_API.Models;

namespace To_Do_List_API.Interfaces
{
    public interface ITodos
    {
        public List<Todo> get();
        public Todo insert(Todo todo);
        public void setCompleted(int id);
        public void delete(int id);
    }
}
