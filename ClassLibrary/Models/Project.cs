using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ClassLibrary.Models
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public int typeId { get; set; }
        [ForeignKey("TypeId")]
        public ProjectType type { get; set; }
        public List<ClassLibrary.Model.Task> tasks{ get; set; }
        public string description { get; set; }
        public List<Developer> developers { get; set; }
    }
}
