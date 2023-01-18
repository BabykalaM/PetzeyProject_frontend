using Petzey.Dept.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Dept.Domain.API_models
{
    public class viewDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Status Status { get; set; }
    }
}
