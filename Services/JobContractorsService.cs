using contractor.Models;
using contractor.Repositories;

namespace contractor.Services
{
  public class JobContractorsService
  {
    private readonly JobContractorsRepository _repo;
    public JobContractorsService(JobContractorsRepository repo)
    {
      _repo = repo;
    }
    public JobContractor Create(JobContractor newJC)
    {
      int id = _repo.Create(newJC);
      newJC.id = id;
      return newJC;
    }
    internal string Delete(int id)
    {
      _repo.Delete(id);
      return "Successfully Deleted!!";
    }
  }
}