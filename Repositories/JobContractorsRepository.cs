using System.Data;
using contractor.Models;
using Dapper;

namespace contractor.Repositories
{
  public class JobContractorsRepository
  {
    private readonly IDbConnection _db;
    public JobContractorsRepository(IDbConnection db)
    {
      _db = db;
    }
    public int Create(JobContractor newJc)
    {
      string sql= @"
      INSERT INTO jobcontractors
      (JobId,ContractId)
      VALUES
      (@JobId,@ContractorId);
      SELECT LAST_INSERT_ID()";
      return _db.ExecuteScalar<int>(sql,newJc);
    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM jobcontractors WHERE id= @id;";
      _db.Execute(sql,new {id});
    }
  }
}