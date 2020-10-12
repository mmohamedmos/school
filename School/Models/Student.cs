using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {     
        public int Id { get; set; }
        public string  name { get; set; }
        public string Class { get; set; }
        [ForeignKey("term")]
        public int Termid { get; set; }
        public virtual term Term { get; set; }
    


    }
}
