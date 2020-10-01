using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_API.Models;

namespace To_Do_List_API.Data
{
    public class TodosContext : DbContext
    {
        private string constring = "Data Source=STIFF\\SQLEXPRESS;Initial Catalog=todo;Integrated Security=True";
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(constring);
        }
    }

}
