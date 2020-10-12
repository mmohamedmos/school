using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Subject
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("term") ]
        public int termid { get; set; }
       

    }
}
