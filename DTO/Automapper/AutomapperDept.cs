using AutoMapper;
using Petzey.Dept.Domain.API_models;
using Petzey.Dept.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Dept.Domain.Automapper
{
    public class AutomapperDept : Profile
    {
        public AutomapperDept()
        {
            CreateMap<Department, viewDTO>();
        }
    }
}
