using System.Linq;
using System.Net;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DepartmentController : ApiController
    {
        EntityModel context = new EntityModel();
	
 	[HttpGet]
        [Route("GetDepartment")]
        public IHttpActionResult Get(int id)
        {
            Department department = context.Departments.Where(p => p.DepartmentId == id).FirstOrDefault();
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }
	
  	[HttpPost]
        [Route("AddDepartment")]
        public IHttpActionResult Post(Department department)
        {
            if (department != null)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = department.DepartmentId }, department);
            }
            return BadRequest();
        }

	[HttpPost]
        [Route("DeleteDepartment")]
        public IHttpActionResult Put(Department department)
        {
            if (department != null)
            {
                // Do some work .
                return Content(HttpStatusCode.Accepted, department);
            }
            return BadRequest();
        }
    }
}
