using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IPatientBll PatientBll;
        public PatientController(IPatientBll patientBll)
        {
            PatientBll = patientBll;
        }

        // GET: api/<PatientController>
        [HttpGet]
        public List<PatientDto> Get()
        {
            return this.PatientBll.getAll();
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public PatientDto Get(string id)
        {
            return this.PatientBll.getById(id);
        }

        // POST api/<PatientController>
        [HttpPost]
        

        public IActionResult Post([FromBody] PatientDto value)
        {
            if (value.dateRecovery > value.datePositiveResult)
            {
                this.PatientBll.post(value);
                return Ok(); // Return a success response if the patient is added successfully
            }
            else
            {
                return BadRequest("Recovery date must be after the positive result date.");
            }
        }
        [HttpPost("{tz}")]
        public IActionResult vaccinePatient(string tz, [FromBody] CoronaDto value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var patient = this.PatientBll.getById(tz);
            if(patient == null)
            {
                return NotFound("no patient exsist");
            }
            bool addVaccine=this.PatientBll.AddpatientVaccine(tz,value);
            if(addVaccine)
            {
                return Ok();
            }
            else
            {
                return BadRequest("you can add maxsimon 4 vaccine for one patient");
            }
        }

    }
}
