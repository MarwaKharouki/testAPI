using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NextGenConfig.entities.models;
using NextGenConfig.Repositories.IRepository;

namespace NextGenConfig.API.Controllers
{
    //httpclient.post("localhost:5501//api/Systemprofile")
    [Route("api/[controller]")]
    [ApiController]
    public class SystemProfileController : ControllerBase
    {
        IBaseRepository<SystemProfile> baseRepository;
        public SystemProfileController(IBaseRepository<SystemProfile> baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var systemProfile = baseRepository.GetById(id);
            if (systemProfile==null)
            {
                return NotFound();
                //return NotFound(new Response { Code = "200", Data = null, Status = "0", Msg = "Vehicles was not found" });
            }
            return Ok(systemProfile);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(string value)
        {
            try
            {
                SystemProfile systemProfile = new SystemProfile
                {
                    Name = value
                };
                baseRepository.Add(systemProfile);
                baseRepository.Save();
                return Ok("task completed success fully");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message + "inner exception" + e.InnerException!=null?e.InnerException.Message:"");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
