using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace BasicVersion1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CompanyController : Controller


    //---------------------Simple Data--------------------//
    {
        private static List<Models.COMPANY> Comp = new List<Models.COMPANY>
        {
            new Models.COMPANY
            {
                CompanyId = 1,
                CompanyName = "HR",
                CompanyAddress = "KKC"
            },
            new Models.COMPANY
            {
                CompanyId = 2,
                CompanyName = "MA",
                CompanyAddress = "BKK"
            }
        };

        
       

        [HttpGet]
        public async Task<ActionResult<List<Models.COMPANY>>> get()
        {
            //   return Ok(await _datacontext.COMPANY.ToListAsync());
            return Ok(Comp);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.COMPANY>> SearchCompany(int id)
        {
            //var CompanyFromDb = await _datacontext.COMPANY.ToListAsync();
            //var company = CompanyFromDb.Find(x => x.CompanyId == id);
            var company = Comp.Find(x => x.CompanyId == id);
            if (company == null)
                return BadRequest();
            //return Ok(company);
            return Ok(company);
        }


        [HttpPost]
        public async Task<ActionResult<List<Models.COMPANY>>> AddCompany(Models.COMPANY Com)
        {
            //_datacontext.COMPANY.Add(Com);
            //await _datacontext.SaveChangesAsync();
            //return Ok(await _datacontext.COMPANY.ToListAsync());
            Comp.Add(Com);
            return Ok(Comp);
        }

        [HttpPut]
        public async Task<ActionResult<List<Models.COMPANY>>> UpdateCompany(Models.COMPANY Com)
        {
            // var CompanyFromDb = await _datacontext.COMPANY.FindAsync(Com.CompanyId);
            // if (CompanyFromDb == null)
            //    return BadRequest("Order Error");

            //  CompanyFromDb.CompanyId = Com.CompanyId;
            //  CompanyFromDb.CompanyName = Com.CompanyName;
            //  await _datacontext.SaveChangesAsync();
            //   return Ok(await _datacontext.COMPANY.ToListAsync());
            var CompanyFromDb = Comp.Find(x => x.CompanyId == Com.CompanyId);
            if (CompanyFromDb == null)
                return NotFound();



            CompanyFromDb.CompanyId = Com.CompanyId;
            CompanyFromDb.CompanyName = Com.CompanyName;
            CompanyFromDb.CompanyAddress = Com.CompanyAddress;
            return Ok(Com);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Models.COMPANY>>> DeleteCompany(Models.COMPANY Com)
        {
            //    var CompanyFromDb = await _datacontext.COMPANY.FindAsync(Com.CompanyId);
            //  if (CompanyFromDb == null)
            //  return NotFound("Delete Error");
            //  _datacontext.Remove(CompanyFromDb);
            //   await _datacontext.SaveChangesAsync();
            //  return Ok(await _datacontext.COMPANY.ToListAsync());

            var CompanyFromDb = Comp.Find(x => x.CompanyId == Com.CompanyId);
            if (CompanyFromDb == null)
                return NotFound();
            Comp.Remove(CompanyFromDb);
            return Ok(Comp);

        }



    }
}

