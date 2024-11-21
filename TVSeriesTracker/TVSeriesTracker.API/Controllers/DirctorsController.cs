using Microsoft.AspNetCore.Mvc;
using TVSeriesTracker.Application.Directors.Commands.CreateDirector;
using TVSeriesTracker.Application.Directors.Queries.GetDirectorDetail;

namespace TVSeriesTracker.API.Controllers
{
    [Route("api/directors")]
    public class DirctorsController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<DirectorDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetDirectorDetailQuery { DirectorId = id });
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDirector(CreateDirectorCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}