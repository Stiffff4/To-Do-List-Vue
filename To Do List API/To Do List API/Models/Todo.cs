using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do_List_API.Models
{
    public class Todo
    {
        [Key]
        public Int32 id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        public bool deleted { get; set; }

        public Todo()
        {

        }
        public Todo (string title, bool completed, bool deleted)
        {
            this.title = title;
            this.completed = completed;
            this.deleted = deleted;
        }
    }
}
