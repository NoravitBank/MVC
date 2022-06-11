using Microsoft.AspNetCore.Mvc;

namespace BasicVersion1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private static List<Models.EMPLOYEE> Emp = new List<Models.EMPLOYEE>
             {
                 new Models.EMPLOYEE
                 {
                      EmployeeId = 1,
                      EmployeeName = "Noravit",
                      EmployeeAddress = "Loei",
                      EmployeeTel = "0823394623"

                 },
                 new Models.EMPLOYEE
                 {
                     EmployeeId = 2,
                      EmployeeName = "Kamsing",
                      EmployeeAddress = "BKK",
                      EmployeeTel = "0913458742"


                 }
             };



        private readonly DataContext _dataContext;

        public EmployeeController(BasicVersion1.Data.DataContext datacontext)
        {
            _dataContext = datacontext;
        }



        [HttpGet]
        public async Task<ActionResult<List<Models.EMPLOYEE>>> Get()
        {
            //   return Ok(await _dataContext.EMPLOYEE.ToListAsync());
            return Ok(Emp);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.EMPLOYEE>> Get(int id)
        {
            //   var EmployeeFromDb = await _dataContext.EMPLOYEE.ToListAsync();
            //   var employee = EmployeeFromDb.Find(it => it.EmployeeId == id);
            //   if (employee == null)
            //       return NotFound("Not Found Employee");
            //   return Ok(employee);
            var Employee = Emp.Find(x => x.EmployeeId == id);
            if (Employee == null)
                return BadRequest();
            //return Ok(company);
            return Ok(Employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Models.EMPLOYEE>>> AddEmployee(Models.EMPLOYEE AddEmp)
        {
            //   _dataContext.EMPLOYEE.Add(AddEmp);
            //  await _dataContext.SaveChangesAsync();
            //  return Ok(await _dataContext.EMPLOYEE.ToListAsync());
            Emp.Add(AddEmp);
            return Ok(Emp);
        }

        [HttpPut]
        public async Task<ActionResult<List<Models.EMPLOYEE>>> UpdateEmployee(Models.EMPLOYEE UpdateEmp)
        {
            //    var EmployeeFromDb = await _dataContext.EMPLOYEE.ToListAsync();
            //    var employee = EmployeeFromDb.Find(it => it.EmployeeId == UpdateEmp.EmployeeId);
            //   if (employee == null)
            //       return BadRequest("Update Failse");

            //automapper

            //    employee.EmployeeId = UpdateEmp.EmployeeId;
            //    employee.EmployeeName = UpdateEmp.EmployeeName;
            //    employee.EmployeeAddress = UpdateEmp.EmployeeAddress;
            //    employee.EmployeeTel = UpdateEmp.EmployeeTel;

            //   return Ok(await _dataContext.EMPLOYEE.ToListAsync());
            var Employee = Emp.Find(x => x.EmployeeId == UpdateEmp.EmployeeId);
            if (Employee == null)
                return NotFound();
            Employee.EmployeeId = UpdateEmp.EmployeeId;
            Employee.EmployeeName = UpdateEmp.EmployeeName;
            Employee.EmployeeAddress = UpdateEmp.EmployeeAddress;
            Employee.EmployeeTel = UpdateEmp.EmployeeTel;
            return Ok(Emp);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Models.EMPLOYEE>>> DeleteEmployee(Models.EMPLOYEE DeleteEmp)
        {
            //   var EmployeeFromDb = await _dataContext.EMPLOYEE.ToListAsync();
            //    var employee = EmployeeFromDb.Find(it => it.EmployeeId == DeleteEmp.EmployeeId);
            //    if (employee == null)
            //        return NotFound("Delete Error");
            //    _dataContext.EMPLOYEE.Remove(DeleteEmp);
            //    await _dataContext.SaveChangesAsync();
            //    return Ok(await _dataContext.EMPLOYEE.ToListAsync());
            var Employee = Emp.Find(x => x.EmployeeId == DeleteEmp.EmployeeId);
            if (Employee == null)
                return NotFound();
            Emp.Remove(Employee);
            return Ok(Emp);
        }

    }
}
