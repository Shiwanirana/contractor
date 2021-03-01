using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractWorkersController : ControllerBase
  {
    private readonly ContractWorkersService _cs;
    // private readonly BricksService _bs;

    public ContractWorkersController(ContractWorkersService cs)
    {
      _cs = cs;
      // _bs = bs;
    }

    // GET api/ContractWorkers
    [HttpGet]
    public ActionResult<IEnumerable<ContractWorker>> Get()
    {
      try
      {
        return Ok(_cs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // GET api/ContractWorkers/5
    [HttpGet("{id}")]
    public ActionResult<ContractWorker> Get(int id)
    {
      try
      {
        return Ok(_cs.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // POST api/ContractWorkers
    [HttpPost]
    public ActionResult<ContractWorker> Post([FromBody] ContractWorker newContractWorker)
    {
      try
      {
        return Ok(_cs.Create(newContractWorker));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // DELETE api/ContractWorkers/5
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_cs.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}