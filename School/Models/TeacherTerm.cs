using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class TeacherTerm
    {
        public int ID { get; set; }
        public TeacherTerm()
        {
        }
        public  Teacher Teacher { set; get; }
        [ForeignKey("Teacher")]
        public int teacherId { get; set; }
        public  term Term{ get; set; }
        [ForeignKey("Term")]
        public int termId { get; set; }
    }
}
