using System;
using System.Collections.Generic;
using System.Data;
using contractor.Models;
using Dapper;
namespace contractor.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Job> Get()
    {
      string sql = "SELECT * FROM jobs;";
      return _db.Query<Job>(sql);
    }

    internal Job Get(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id;";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    internal int Create(Job newJob)
    {
      string sql = @"
      INSERT INTO jobs
      (Title, Location, Description)
      VALUES
      (@Title, @Location, @Description);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newJob);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @id;";
      _db.Execute(sql, new { id });
    }


    // internal IEnumerable<Brick> GetBricksByKitId(int kitId)
    // {
    //   string sql = @"
    //   SELECT b.*,
    //   kb.id as KitBrickId 
    //   FROM kitbricks kb
    //   JOIN bricks b ON b.id = kb.brickId
    //   WHERE kitId = @kitId";

    //   return _db.Query<KitBrickViewModel>(sql, new { kitId });
    // }
  }
}