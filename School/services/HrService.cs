using AutoMapper;
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
    public class HrService:IHrService
    {
        private readonly IMapper _mapper;

        public HrService(Iunitofwork Unitofwork,IMapper mapper)
        {
            this.Unitofwork = Unitofwork;
           _mapper = mapper;
            ;
        }

        private Iunitofwork Unitofwork { get; }

        public HrDto LoginHr(HR value)
        {
            HR HrCheck = Unitofwork.hrrepo.getAll().FirstOrDefault(hr => hr.Name == value.Name&&hr.Password==value.Password);
            if (HrCheck == null)
            {
                return null;
            }
            HrDto HrReturn = _mapper.Map<HrDto>(HrCheck);
            return HrReturn;
        }
        public HrDto Register(HR value)
        {
            HR HrCheck = Unitofwork.hrrepo.getAll().FirstOrDefault(hr => hr.Name == value.Name);
            if (HrCheck == null)
            {
                Unitofwork.hrrepo.Add(value);
                Unitofwork.Commit();
                HrDto HrReturn = _mapper.Map<HrDto>(value);
                return HrReturn;
            }
            return null;


        }



    }
}
