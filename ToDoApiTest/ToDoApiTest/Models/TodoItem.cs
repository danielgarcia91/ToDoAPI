using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApiTest.Models
{
    public class TodoItem
    {
        public long Id { get; set;} //This is the unique key in a relational db
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
