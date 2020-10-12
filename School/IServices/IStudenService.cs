using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.IServices
{
   public interface IStudenService
    {
        Student Get(int id);
        List<Student> GetAll();
        void Put(int id);
        void Delete(int id);
        void Post(Student value);
    }
}
