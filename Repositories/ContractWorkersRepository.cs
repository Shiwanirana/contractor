using System;
using System.Collections.Generic;
using System.Data;
using contractor.Models;
using Dapper;
namespace contractor.Repositories
{
  public class ContractWorkersRepository
  {
    private readonly IDbConnection _db;

    public ContractWorkersRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<ContractWorker> Get()
    {
      string sql = "SELECT * FROM contractworkers;";
      return _db.Query<ContractWorker>(sql);
    }

    internal ContractWorker Get(int id)
    {
      string sql = "SELECT * FROM contractworkers WHERE id = @id;";
      return _db.QueryFirstOrDefault<ContractWorker>(sql, new { id });
    }

    internal int Create(ContractWorker newContractWorker)
    {
      string sql = @"
      INSERT INTO contractworkers
      (Name, Ratings)
      VALUES
      (@Name, @Ratings);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newContractWorker);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM contractworkers WHERE id = @id;";
      _db.Execute(sql, new { id });
    }


    internal IEnumerable<ContractWorker> GetJcByJobId(int jobId)
    {
      string sql = @"
      SELECT c.*,
      jc.id as JobContractorId 
      FROM jobcontractors jc
      JOIN contractworkers c ON c.id = jc.ContractId
      WHERE JobId = @jobId";

      return _db.Query<JobContractorViewModel>(sql, new { jobId });
    }
  }
}