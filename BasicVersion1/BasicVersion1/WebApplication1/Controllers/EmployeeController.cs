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
                .Include(e => e.DEPARTMENT)
                .Include(e => e.COMPANY)
                .ToListAsync();   
            if(employee == null)
                return NotFound();
            return employee;
        }

        [HttpGet]
        public async Task<ActionResult<List<EMPLOYEE>>> show()
        {         
            return await _context.EMPLOYEEs.Include(e => e.POSITION)
                .Include(p => p.DEPARTMENT)
                .Include(p => p.COMPANY)
                .ToListAsync();
        }

        [HttpGet("PosoitionSearch")]
        public async Task<ActionResult<List<EMPLOYEE>>> PositionSearch(string positionName)
        {
            var posi = await _context.EMPLOYEEs.Where(p => p.POSITION.POSITION_NAME_THA == positionName)
                .Include(p => p.POSITION)
                .Include(p => p.DEPARTMENT)
                .Include(p => p.COMPANY)
                .ToListAsync();
            if (posi == null)
                return NotFound();
            return posi;
        }

        [HttpGet("DepartmentSearch")]
        public async Task<ActionResult<List<EMPLOYEE>>> DepartmentSearch(string departmentName)
        {
            var depm = await _context.EMPLOYEEs.Where(d => d.DEPARTMENT.DEPARTMENT_NAME_THA == departmentName)
                .Include(d => d.POSITION)
                .Include(d => d.DEPARTMENT)
                .Include(d => d.COMPANY)
                .ToListAsync();
            if (depm == null)
                return NotFound();
            return depm;
        }

        [HttpGet("CompanySearch")]
        public async Task<ActionResult<List<EMPLOYEE>>> CompanySearch(string CompanySearch)
        {
            var comp = await _context.EMPLOYEEs.Where(d => d.COMPANY.COMPANY_NAME_THA == CompanySearch)
                .Include(c => c.POSITION)
                .Include(c => c.DEPARTMENT)
                .Include(c => c.COMPANY)
                .ToListAsync();
            if (comp == null)
                return NotFound();
            return comp;
        }



        [HttpPost]
        public async Task<ActionResult<List<EMPLOYEE>>> Create(CreateEmployeeDTO request)
        {
            var position = await _context.POSITIONs.FindAsync(request.PositionId);
            var department = await _context.DEPARTMENTs.FindAsync(request.DepartmentId);
            var company = await _context.COMPANYs.FindAsync(request.CompanyId);
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
                DEPARTMENT = department,
                COMPANY = company                         
            };
            _context.EMPLOYEEs.Add(newEmployee);
            await _context.SaveChangesAsync();            
            return Ok();
        }

    }
}
