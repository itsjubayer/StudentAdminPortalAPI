using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalAPI.Repository;

namespace StudentAdminPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentRepository _StudentRepo;
        public StudentsController(IStudentRepository studentRepo)
        {
            _StudentRepo = studentRepo;
        }

        [Route("[action]")]
        public IActionResult GetAllStudent()
        {
            return Ok(_StudentRepo.GetAllStudents());
        }


        //How to code?
        //model->interface(Repository)->implement->Code in Controller->in pogram add injection(addSchope)
        [Route("GetAllStudentAsync")]
        public async Task<IActionResult> GetAllStudentAsync()
        {
            return Ok(await _StudentRepo.GetAllStudentsAsync());
        }

    }
}
