using Microsoft.AspNetCore.Mvc;

namespace BasicVersion1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {


        private static List<Models.DEPARTMENT> Depm = new List<Models.DEPARTMENT>
        {
            new Models.DEPARTMENT
            {
                DepartmentId = 1,
                DepartmentName = "HR",
                DepartmentAddress = "KKC"
            },
            new Models.DEPARTMENT
            {
                DepartmentId = 2,
                DepartmentName = "MA",
                DepartmentAddress = "BBK"
            }
        };



        //    private readonly DataContext _dataContext;

        //   public DepartmentController(BasicVersion1.Data.DataContext datacontext)
        //    {
        //       _dataContext = datacontext;
        //   }

        [HttpGet]
        public async Task<ActionResult<List<Models.DEPARTMENT>>> get()
        {
            //        return Ok(await _dataContext.DEPARTMENT.ToListAsync());
            return Ok(Depm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Models.DEPARTMENT>>> SearchDepartment(int id)
        {
            //        var DepartmentFromDb = await _dataContext.DEPARTMENT.ToListAsync();
            //        var Department = DepartmentFromDb.Find(x => x.DepartmentId == id);
            //        if (Department == null)
            //            return NotFound();
            //        return Ok(Department);
            var department = Depm.Find(x => x.DepartmentId == id);
            if (department == null)
                return BadRequest();
            return Ok(department);
        }

        [HttpPost]
        public async Task<ActionResult<List<Models.DEPARTMENT>>> AddDepartment(Models.DEPARTMENT Dep)
        {
            //        _dataContext.DEPARTMENT.Add(Dep);
            //        await _dataContext.SaveChangesAsync();
            //        return Ok(await _dataContext.DEPARTMENT.ToListAsync());
            Depm.Add(Dep);
            return Ok(Depm);
        }

        [HttpPut]
        public async Task<ActionResult<List<Models.DEPARTMENT>>> UpdateDepartment(Models.DEPARTMENT Dep)
        {
            //        var DepartmentFromDb = await _dataContext.DEPARTMENT.ToListAsync();
            //       var Department = DepartmentFromDb.Find(ti => ti.DepartmentId == Dep.DepartmentId);
            //        if (Department == null)
            //          return BadRequest("Update Error");
            //
            //       Department.DepartmentId = Dep.DepartmentId;
            //       Department.DepartmentName = Dep.DepartmentName;
            //        return Ok(await _dataContext.DEPARTMENT.ToListAsync());
            var department = Depm.Find(x => x.DepartmentId == Dep.DepartmentId);
            if (department == null)
                return NotFound();
            department.DepartmentId = Dep.DepartmentId;
            department.DepartmentName = Dep.DepartmentName;
            department.DepartmentAddress = Dep.DepartmentAddress;
            return Ok(Depm);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Models.DEPARTMENT>>> DeleteDepartmaet(Models.DEPARTMENT Dep)
        {
            //       var DepartmentFromDb = await _dataContext.DEPARTMENT.ToListAsync();
            //        var Department = DepartmentFromDb.Find(it => it.DepartmentId == Dep.DepartmentId);
            //        if (Department == null)
            //            return NotFound("Delete Error");
            //        _dataContext.DEPARTMENT.Remove(Dep);
            //       await _dataContext.SaveChangesAsync();  
            //       return Ok(await _dataContext.DEPARTMENT.ToListAsync());
            var department= Depm.Find(x => x.DepartmentId == Dep.DepartmentId);
            if (department == null)
                return NotFound();
            Depm.Remove(department);
            return Ok(Depm);
        }


    }
}
