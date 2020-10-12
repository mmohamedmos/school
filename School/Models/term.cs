using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class term
    {
        public  int Id { get; set; }
        public string name { get; set; }
        public ICollection<Subject> subject { get; set; } = new HashSet<Subject>();
        //public ICollection<Student>Student  { get; set; } =new HashSet<Student>();
        


    }
}
