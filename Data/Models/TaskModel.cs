using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApplication.Data.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; }

        public bool IsComplete { get; set; }
    }
}
