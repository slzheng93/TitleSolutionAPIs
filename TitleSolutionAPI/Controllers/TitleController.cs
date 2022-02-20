using Application_Core.Contracts.Services;
using Application_Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TitleSolutionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
        private readonly IService _service;
        // Constructor injection
        public TitleController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllTitle")]
        public async Task<ActionResult> GetAllTitle() 
        {
            var titles = await _service.GetAllTitle();

            if(titles == null || titles.Count == 0)
            {
                return NotFound();
            }
            return Ok(titles);
        }
        [HttpGet]
        [Route("SearchByName/{name}")]
        public async Task<ActionResult> SearchByName(string name)
        {
            var titles = await _service.SearchTitleByName(name);

            //if (titles == null || titles.Count == 0)
            //{
            //    return NotFound("Search Not Found");
            //}
            return Ok(titles);
        }
        [HttpGet]
        [Route("GetDetailsByTitleId/{titleId:int}")]
        public async Task<ActionResult> GetTitleDetail(int titleId)
        {
            var titleDetails = await _service.GetTitleDetail(titleId);

            if(titleDetails == null)
            {
                return NotFound(titleId);
            }
            return Ok(titleDetails);
        }
    }
}
