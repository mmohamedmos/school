using AutoMapper;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.DtoModels
{
    public class AutoMapperProfile:Profile  
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<HR, HrDto>();
        }
    }
}
