using Petzey.Dept.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Dept.Domain.Repository
{
    public interface IDeptRepository
    {
        List<Department> GetAllDepts();
        Department GetDeptById(int id);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department,int deptId);
        void DeleteDepartment(int id);
    }
}
