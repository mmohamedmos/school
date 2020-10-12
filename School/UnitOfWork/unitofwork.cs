using School.Models;
using School.Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.UnitOfWork
{
    public class unitofwork :Iunitofwork
    {
        private SchoolRepositry<Student> studentRepo;
        private SchoolRepositry<HR> HrRepo;
        private SchoolDbContext SchoolDbContext { get; }
        public unitofwork(SchoolDbContext schoolDbContext)
        {
          
            SchoolDbContext = schoolDbContext;        
        }

        public SchoolRepositry<Student> sturepo
        {
            get {             
                this.studentRepo= new SchoolRepositry<Student>(SchoolDbContext);    
                return studentRepo;
                }
        }
        public SchoolRepositry<HR> hrrepo
        {
            get
            {
                
                this.HrRepo = new SchoolRepositry<HR>(SchoolDbContext);               
                return HrRepo;
            }

        }


        public void Commit()
        {
            SchoolDbContext.SaveChanges();
        }

       
    }
}
