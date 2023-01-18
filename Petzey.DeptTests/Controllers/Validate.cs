using Microsoft.AspNetCore.Server.IIS.Core;
using Petzey.Dept.Controllers.Tests;
using Petzey.Dept.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.DeptTests.Controllers
{
    public class Validate
    {
        //Department dept = new Department();
        public bool validateDept(string deptName)
        {
            if (deptName == null)
            {
                throw new NotNullException("Dept Name should not be null or Empty");
            }
            return true;
        }
    }
}
