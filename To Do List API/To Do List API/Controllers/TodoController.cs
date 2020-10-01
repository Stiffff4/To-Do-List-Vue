using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using To_Do_List_API.Models;
using Microsoft.AspNetCore.Cors;
using To_Do_List_API.Interfaces;

namespace To_Do_List_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : Controller
    {
        private ITodos i = new TodosImpl();
        private List<Todo> list;

        [HttpGet]
        public List<Todo> get()
        {
            list = i.get();

            bool isEmpty = !list.Any();

            if (isEmpty)
            {
                Response.StatusCode = 204;
            }
            else
            {
                Response.StatusCode = 200;
            }

            return list;
        }

        [HttpPost]
        public Todo insert(Todo todo)
        {
            i.insert(todo);
            Response.StatusCode = 201;
            return todo;
        }

        [HttpPut("{id}")]
        public void setCompleted(int id)
        {
            Response.StatusCode = 200;
            i.setCompleted(id);
        }

        [HttpDelete("{id}")]
        public void delete(int id)
        {
            Response.StatusCode = 200;
            i.delete(id);
            
        }
    }
}