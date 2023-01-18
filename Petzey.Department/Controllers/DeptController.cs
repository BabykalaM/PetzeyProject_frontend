using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLog;
using Petzey.Dept.Data;
using Petzey.Dept.Domain.API_models;
using Petzey.Dept.Domain.Entities;
using Petzey.Dept.Domain.Repository;
namespace Petzey.Dept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        private IDeptRepository repo; // new DeptRepository();
        private IMapper mapper;
        private static NLog.ILogger _logger = LogManager.GetCurrentClassLogger();
        public DeptController(IDeptRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        //public DeptController()
        //{
        //}

        [HttpGet]
        [EnableQuery]

        public IActionResult GetAllDept()
        {
            try
            {
                var dept = repo.GetAllDepts().AsQueryable();
                var viewDept = mapper.Map<IEnumerable<viewDTO>>(dept);
                if (viewDept != null) return Ok(viewDept);
                return NotFound("Department not found");
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("/api/dept/{id}")]
        public IActionResult GetDeptById(int id)
        {
            try
            {
                return Ok(repo.GetDeptById(id));
                //var viewDept = mapper.Map<IEnumerable<viewDTO>>(dept);
               // if (viewDept != null) return Ok(viewDept);
                //return NotFound("Department not found");
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public IActionResult AddDept(Department department)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest("Invalid Department data"); }
                repo.AddDepartment(department);
                return Created($"/api/dept/{department.DepartmentId}", department);
            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return BadRequest(ex.Message);
            }
            
        }
        [HttpPut]
        [Route("{deptId}")]
        public IActionResult EditDept(Department department,int deptId)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest("Invalid Department data"); }
                repo.UpdateDepartment(department, deptId);
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("{deptId}")]
        public IActionResult DeleteDept(int deptId)
        {
            try
            {
                var dept = repo.GetDeptById(deptId);
                if (dept == null) { return NotFound("Department Data not found"); }
                else
                {
                    repo.DeleteDepartment(deptId);
                    return Ok(dept);
                }
            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return BadRequest(ex.Message);
            }
            
        }
    }
}
