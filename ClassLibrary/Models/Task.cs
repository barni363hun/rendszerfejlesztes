using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int projectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project project { get; set; }
        public int managerId { get; set; }
        [ForeignKey("ManagerId")]
        public Manager manager { get; set; }
        public DateTime deadline { get; set; }
    }
}
