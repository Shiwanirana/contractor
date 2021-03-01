using System;
using contractor.Models;
using contractor.Services;
using Microsoft.AspNetCore.Mvc;
namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobContractorsController : ControllerBase
  {
    private readonly JobContractorsService _service;
    public JobContractorsController(JobContractorsService service)
    {
      _service = service;
    }
    // [HttpGet]
    // public ActionResult<JobContractor> Get()
    // {
    //   try{
    //   return Ok(_service.Get());
    //   }
    //   catch(Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }
    [HttpPost]
    public ActionResult<JobContractor> Create([FromBody] JobContractor newJc)
    {
      try
      {
        return Ok(_service.Create(newJc));
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}