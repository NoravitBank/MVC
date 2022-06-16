using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;

        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Id")]
        public async Task<ActionResult<List<EMPLOYEE>>> Get(int EmpId)
        {
            var employee = await _context.EMPLOYEEs.Where(e => e.EMPLOYEE_CODE == EmpId)                 
                .Include(e => e.POSITION)                
                .ToListAsync();           
            return employee;
        }

        [HttpGet]
        public async Task<ActionResult<List<EMPLOYEE>>> show()
        {         
            return await _context.EMPLOYEEs.Include(e => e.POSITION)
                .Include(p => p.DEPARTMENT).ToListAsync();

        }



        [HttpPost]
        public async Task<ActionResult<List<EMPLOYEE>>> Create(CreateEmployeeDTO request)
        {
            var position = await _context.POSITIONs.FindAsync(request.PositionId);
            //var department = await _context.DEPARTMENTs.FindAsync(request.DepartmentId);
            if (position == null)
                return NotFound();

            var newEmployee = new EMPLOYEE
            {
                FIRST_NAME_THA = request.FIRST_NAME_THA,
                LAST_NAME_THA = request.LAST_NAME_THA,
                FIRST_NAME_ENG = request.FIRST_NAME_ENG,
                LAST_NAME_ENG = request.LAST_NAME_ENG,
                NICKNAME = request.NICKNAME,
                GENDER = request.GENDER,
                BIRTH_DATE = request.BIRTH_DATE,
                NATIONALITY_ID = request.NATIONALITY_ID,
                RACE_ID = request.RACE_ID,
                RELIGION = request.RELIGION,
                BLOOD_TYPE = request.BLOOD_TYPE,
                PHONE_EMPLOYEE = request.PHONE_EMPLOYEE,
                EMAIL = request.EMAIL,
                POSITION = position,
            //    DEPARTMENT =department               
            };
            _context.EMPLOYEEs.Add(newEmployee);
            await _context.SaveChangesAsync();            
            return Ok();
        }

    }
}
