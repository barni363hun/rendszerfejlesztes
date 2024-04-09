using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ClassLibrary.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Project_Type Type { get; set; }
        public List<ClassLibrary.Model.Task> Tasks{ get; set; }
        public string Description { get; set; }
        public List<Developer> Developers { get; set; }
    }
}
