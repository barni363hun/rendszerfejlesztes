using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTOs
{
    public class TaskDTO
    {

        //columns: new[] { "Name", "Description", "ProjectId", "ManagerId", "Deadline" },
        //        values: new object[] { "Task 1", "Make backend", 1, 1, new DateTime(2024, 4, 10) });

        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int ManagerId { get; set; }
        public DateTime Deadline { get; set; }
    }
}
