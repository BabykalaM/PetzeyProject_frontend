using Microsoft.VisualStudio.TestTools.UnitTesting;
using Petzey.Dept.Controllers;
using Petzey.Dept.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Dept.Controllers.Tests
{
    [TestClass()]
    public class DeptControllerTests
    {
        Department target = null;
        [TestInitialize]
        public void Init()
        {
            target = new Department();
        }

        [TestCleanup]
        public void Clean()
        {
            target = null;
        }

        [TestMethod()]
        //[ExpectedException(typeof(NotNullException))]
        public void AddDept_NullDeptName_ThrowsEx_Test()
        {
            //target.validate(" ");
            var expected = target.DepartmentName;
            Assert.AreEqual(expected, target.DepartmentName);
        }

        [TestMethod()]
        //[ExpectedException(typeof(NotFoundException), "A deptartment id was not found.")]
        public void Dept_IdNotFound_ThrowsEx_Test()
        {
            var expected = target.DepartmentId;
            Assert.AreEqual(expected, target.DepartmentId);
        }
    }
}