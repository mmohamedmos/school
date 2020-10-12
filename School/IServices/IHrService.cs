using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.IServices
{
  public  interface IHrService
    {
     
        HR Register(HR value);
        HR LoginHr(HR hr);

    }
}
