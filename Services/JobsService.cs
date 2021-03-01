using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Repositories;
namespace contractor.Services
{
  public class JobsService
  {
    private readonly JobsRepository _repo;
    // private readonly KitsRepository _krepo;

    public JobsService(JobsRepository repo)
    {
      _repo = repo;
      // _krepo = krepo;
    }


    internal IEnumerable<Job> Get()
    {
      return _repo.Get();
    }
    internal Job Get(int id)
    {
      Job data = _repo.Get(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return data;
    }

    internal Job Create(Job newJob)
    {
      int id = _repo.Create(newJob);
      newJob.id = id;
      return newJob;
    }


    internal string Delete(int id)
    {
      Get(id);
      _repo.Delete(id);
      return "Successfully Deleted";
    }



  //   internal IEnumerable<Job> GetBricksByKitId(int kitId)
  //   {
  //     Kit exists = _krepo.Get(kitId);
  //     if (exists == null)
  //     {
  //       throw new Exception("Invalid Id");
  //     }
  //     return _repo.GetBricksByKitId(kitId);
  //   }
  }
}