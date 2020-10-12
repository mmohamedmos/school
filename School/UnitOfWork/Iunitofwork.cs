using School.Models;
using School.Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.UnitOfWork
{
   public interface Iunitofwork
    {
        SchoolRepositry<Student> sturepo { get; }
        SchoolRepositry<HR> hrrepo { get; }
        void Commit();
        
    }
}
