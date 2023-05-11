using Dal;
using Bll;
using Microsoft.AspNetCore.Mvc;
using Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaController : ControllerBase
        
    {
        ICoronaBll CoronaBll;
        public CoronaController(ICoronaBll coronaBll)
        {
           this.CoronaBll = coronaBll;
        }
        [HttpGet]
        public List<CoronaDto> Get()
        {
            return this.CoronaBll.getAll();
        }

        [HttpGet("{id}")]

        public IActionResult Get(string id)
        {
            var result = this.CoronaBll.getById(id);

            if (result == null && result.Count == 0)
            {
                return BadRequest("No patient found with the specified ID.");
            }

            return Ok(result);
        }
    }
}
