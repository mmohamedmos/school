using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Teacher
    {
        
        public int ID { get; set; }
        public string  name { get; set; }
        [ForeignKey("subject")]
        public int SubjectId { get; set; }
        public virtual Subject subject { get; set; }




    }
}
