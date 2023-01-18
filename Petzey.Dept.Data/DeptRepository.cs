using Petzey.Dept.Domain.Entities;
using Petzey.Dept.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Dept.Data
{
    public class DeptRepository : IDeptRepository
    {
        private DeptDbContext db = new DeptDbContext(); 
        public void AddDepartment(Department departmentToSave)
        {
            db.Departments.Add(departmentToSave);
            db.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            var deptToDel = db.Departments.Find(id);
            db.Departments.Remove(deptToDel);
            db.SaveChanges();
        }

        public List<Department> GetAllDepts()
        {
            return db.Departments.ToList();
        }

        public Department GetDeptById(int id)
        {
            return db.Departments.Find(id);
        }

        public void UpdateDepartment(Department department,int deptId)
        {
            var departmentToEdit=db.Departments.FirstOrDefault(x => x.DepartmentId == deptId);
            if(departmentToEdit != null)
            {
                departmentToEdit.DepartmentName = department.DepartmentName;
                departmentToEdit.Description = department.Description;
                departmentToEdit.Status = department.Status;
                db.SaveChanges();
            }   
        }
    }
}
