using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Repositories;

namespace contractor.Services
{
  public class ContractWorkersService
  {
    private readonly ContractWorkersRepository _repo;
    private readonly JobsRepository _jrepo;

    public ContractWorkersService(ContractWorkersRepository repo, JobsRepository jrepo)
    {
      _repo = repo;
      _jrepo = jrepo;
    }


    internal IEnumerable<ContractWorker> Get()
    {
      return _repo.Get();
    }
    internal ContractWorker Get(int id)
    {
      ContractWorker data = _repo.Get(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return data;
    }

    internal ContractWorker Create(ContractWorker newContractWorker)
    {
      int id = _repo.Create(newContractWorker);
      newContractWorker.id = id;
      return newContractWorker;
    }


    internal string Delete(int id)
    {
      Get(id);
      _repo.Delete(id);
      return "Successfully Deleted";
    }



    internal IEnumerable<ContractWorker> GetJcByJobId(int jobId)
    {
      Job data = _jrepo.Get(jobId);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return _repo.GetJcByJobId(jobId);
    }
  }
}