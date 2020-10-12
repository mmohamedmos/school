using Microsoft.EntityFrameworkCore;
using School.DtoModels;
using School.IServices;
using School.Models;
using School.Repositry;
using School.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.services
{
    public class StudentService:IStudenService
    {
        public StudentService(Iunitofwork Unitofwork)
        {
          
            this.Unitofwork = Unitofwork;
        }


        private Iunitofwork Unitofwork { get; }

        public Student Get(int id)
        {
            Student student = Unitofwork.sturepo.getAll().FirstOrDefault(s=>s.Id==id);
            return (student);
        }
        public List<Student> GetAll()
        {
            List<Student> students = Unitofwork.sturepo.getAll().Include(t => t.Term)
                .ThenInclude(s => s.subject).OrderBy(s=>s.name).ToList();
            return students;
        }
        public void Put(int id)
        {
            Unitofwork.sturepo.update((Student => Student.Id == id));
            Unitofwork.Commit();
        }
      
        public void Delete(int id)
        {
            Unitofwork.sturepo.delete(student=>student.Id==id);
            Unitofwork.Commit();

        }
        public void Post(Student value)
        {
            Unitofwork.sturepo.Add(value);
            Unitofwork.Commit();
        }




    }
}
