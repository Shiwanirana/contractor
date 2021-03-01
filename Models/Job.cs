using System.ComponentModel.DataAnnotations;

namespace contractor.Models
{
  public class Job
  {
    public int id {get;set;}
    [Required]
    public string Title{get;set;}
    public string Location{get;set;}
    [MaxLength(200)]
    public string Description {get;set;}
  }
}