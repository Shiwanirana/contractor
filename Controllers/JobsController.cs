using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Services;
using Microsoft.AspNetCore.Mvc;
namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;
    private readonly ContractWorkersService _cs;
    public JobsController(JobsService js, ContractWorkersService cs)
    {
      _js = js;
      _cs = cs;
    }
    [HttpGet]
    public ActionResult<Job> Get()
    {
      try{
      return Ok(_js.Get());
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // GET api/Jobs/5
    [HttpGet("{id}")]
    public ActionResult<Job> Get(int id)
    {
      try
      {
        return Ok(_js.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // POST api/Jobs
    [HttpPost]
    public ActionResult<Job> Post([FromBody] Job newJob)
    {
      try
      {
        return Ok(_js.Create(newJob));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // DELETE api/Jobs/5
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_js.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    
    [HttpGet("{jobId}/JobContractors")]
    public ActionResult<IEnumerable<ContractWorker>> GetJc(int jobId)
    {
      try
      {
        return Ok(_cs.GetJcByJobId(jobId));
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}