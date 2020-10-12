using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.DtoModels;
using School.Models;

namespace School.Repositry
{
    public class SchoolRepositry<TEntety>: ISchoolRepositry<TEntety>where TEntety:class
    {
        public SchoolRepositry(SchoolDbContext schoolDbContext)
        {
            SchoolDbContext = schoolDbContext;
        }

        public SchoolDbContext SchoolDbContext { get; }

        public void Add(TEntety T)
        {
            SchoolDbContext.Set<TEntety>().Add(T);
                      
        }

        public void delete(Func<TEntety, bool> filter)
        {
            TEntety entity = get(filter);
            SchoolDbContext.Set<TEntety>().Remove(entity);         
        }

        public TEntety get(Func<TEntety, bool> filter)
        {         
           TEntety entity = SchoolDbContext.Set<TEntety>().FirstOrDefault(filter);           
            return entity;
        }

        public IQueryable<TEntety> getAll()
        {
            IQueryable<TEntety> entities = SchoolDbContext.Set<TEntety>();          
            return entities;
        }

        public void update(Func<TEntety, bool> filter)
        {
            TEntety entety = get(filter);
            SchoolDbContext.Set<TEntety>().Update(entety);
            
        }

    }
}
