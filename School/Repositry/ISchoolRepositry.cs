using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.DtoModels;
using School.Models;

namespace School.Repositry
{
    public interface ISchoolRepositry<TEntety> where TEntety:class
    {
       
        TEntety get(System.Func<TEntety, bool> filter);
        IQueryable<TEntety> getAll();
        void Add(TEntety T);
        void delete(System.Func<TEntety, bool> filter);
        void update(System.Func<TEntety, bool> filter);
 
    }
}
