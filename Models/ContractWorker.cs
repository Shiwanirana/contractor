using System.ComponentModel.DataAnnotations;

namespace contractor.Models
{
  public class ContractWorker
  {
    public int id{get;set;}
    [Required]
    public string Name{get;set;}
    [Range(0,100)]
    public int Ratings {get;set;}
  }
  public class JobContractorViewModel : ContractWorker
  {
    public int JobContractorId {get;set;}
    public string JobTitle {get;set;}
  }
}