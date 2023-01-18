//using Petzey.Dept.Controllers;
//using Petzey.Dept.Data;
//using Petzey.Dept.Domain.API_models;
//using Petzey.Dept.Domain.Entities;

//namespace DeptUnitTest
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        DeptController target = null;
//        [TestInitialize]
//        public void Init()
//        {
//            target = new DeptController();
//        }

//        [TestCleanup]
//        public void Clean()
//        {
//            target = null;
//        }
//        [TestMethod]
//        public void GetAllDept_UnitTest()
//        {
//            var dept = target.GetAllDept();
//            List<viewDTO> views = new List<viewDTO>();
//            viewDTO view1 = new viewDTO()
//            {
//                DepartmentId = 1,
//                DepartmentName = "Neurology",
//                Status = Status.Active
//            };
//            viewDTO view2 = new viewDTO()
//            {
//                DepartmentId = 2,
//                DepartmentName = "Cardiology",
//                Status = Status.InActive
//            };
//            views.Add(view1);
//            views.Add(view2);
//            views.Equals(dept);
//        }

//        [TestMethod]
//        public void AddDept_UnitTest()
//        {
//            Department department1 = new Department()
//            {
//                DepartmentName = "Neurology",
//                Description="about neurology",
//                Status = Status.Active
//            };
//            var dept = target.AddDept(department1);
//            DeptDbContext db = new DeptDbContext();
//            var cou = db.Departments.ToList().Count();
//            int exp = 14;
//            Assert.AreEqual(exp, cou);
//        }
//    }
//}