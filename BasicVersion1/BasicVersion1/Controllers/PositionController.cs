using Microsoft.AspNetCore.Mvc;

namespace BasicVersion1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PositionController : Controller
    {


        private static List<Models.POSITION> Posi = new List<Models.POSITION>
        {
            new Models.POSITION
            {
                PositionId = 1,
                PositionName = "IT",
                PositionDescription = "sad;dasd"
            },
            new Models.POSITION
            {
                PositionId = 2,
                PositionName = "HR",
                PositionDescription = "dasytd"
            }
        };


        //    private readonly DataContext _dataContext;
        //   public PositionController(BasicVersion1.Data.DataContext datacontext)
        //    {
        //       _dataContext = datacontext;
        //   }

        [HttpGet]
        public async Task<ActionResult<List<Models.POSITION>>> ShowPosition()
        {
            //   return Ok(await _dataContext.POSITION.ToListAsync());
            return Ok(Posi);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.POSITION>> Get(int id)
        {
            //   var PositionFromDb = await _dataContext.POSITION.ToListAsync();
            //    var Position = PositionFromDb.Find(it => it.PositionId == id);
            //    if (Position == null)
            //        return NotFound("Not Found Position");
            //    return Ok(Position);
            var position = Posi.Find(x => x.PositionId == id);
            if (position == null)
                return BadRequest();
            //return Ok(company);
            return Ok(position);
        }

        [HttpPost]
        public async Task<ActionResult<List<Models.POSITION>>> AddPosition(Models.POSITION AddPosi)
        {
            //    _dataContext.POSITION.Add(AddPosi);
            //    await _dataContext.SaveChangesAsync();
            //    return Ok(await _dataContext.POSITION.ToListAsync());
            Posi.Add(AddPosi);
            return Ok(Posi);
        }

        [HttpPut]
        public async Task<ActionResult<List<Models.POSITION>>> UpdatePosition(Models.POSITION UpdatePosi)
        {
            //    var PositionFromDb = await _dataContext.POSITION.ToListAsync();
            //    var Position = PositionFromDb.Find(it => it.PositionId == UpdatePosi.PositionId);
            //    if (Position == null)
            //        return BadRequest("Update Failse");
            //
            //    Position.PositionId = UpdatePosi.PositionId;
            //    Position.PositionName = UpdatePosi.PositionName;
            //    return Ok(await _dataContext.POSITION.ToListAsync());
            var position = Posi.Find(x => x.PositionId == UpdatePosi.PositionId);
            if (position == null)
                return NotFound();
            position.PositionId = UpdatePosi.PositionId;
            position.PositionName = UpdatePosi.PositionName;
            position.PositionDescription = UpdatePosi.PositionDescription;
            return Ok(Posi);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Models.POSITION>>> DeletePosition(Models.POSITION DeletePosi)
        {
            //   var PositionFromDb = await _dataContext.POSITION.ToListAsync();
            //   var Position = PositionFromDb.Find(it => it.PositionId == DeletePosi.PositionId);
            //   if (Position == null)
            //        return NotFound("Don't Have Position");
            //   _dataContext.POSITION.Remove(DeletePosi);
            //   await _dataContext.SaveChangesAsync();
            //   return Ok(await _dataContext.POSITION.ToListAsync());
            var position = Posi.Find(x => x.PositionId == DeletePosi.PositionId);
            if (position == null)
                return NotFound();
            Posi.Remove(position);
            return Ok(Posi);
        }
    }

}
