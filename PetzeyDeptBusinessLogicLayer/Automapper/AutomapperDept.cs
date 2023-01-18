using AutoMapper;
using Petzey.Dept.Domain.Entities;
using PetzeyDeptDTO.UserView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetzeyDeptBusinessLogicLayer.Automapper
{
    public class AutomapperDept:Profile
    {
        public AutomapperDept()
        {
            CreateMap<Department, viewDTO>();
        }
    }
}
