using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class ProjectType
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Project> projects { get; set; }
    }
}
