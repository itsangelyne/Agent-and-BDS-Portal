using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;


public class Cgl_submittedReport
{
    [Key]
    public int id { get; set; }
    public string? PolicyHolder { get; set; }
    public string NameofInsured { get; set; }
    public string CivilStatus { get; set; }
    public string Gender { get; set; }
    public string Height { get; set; } 
    public string Weight { get; set; } 
    public string Address { get; set; } 
    public long? ContactNumber { get; set; }
    public string? EmailAddress { get; set; } 
    public int Age { get; set; }
    public DateTime? DateofBirth { get; set; }
    public string PlaceofBirth { get; set; } 
    public string Nationality { get; set; } 
    public long? GovernmentIDNo { get; set; }
    public string SourceofFunds { get; set; } 
    public string NatureofSelfEmployment { get; set; }
    public string AddressofEmployer { get; set; } 
    public string OccupationNLivelihood { get; set; } 
    public DateTime date { get; set; } = DateTime.Now;
    public long? AmountofInsurance { get; set; }
    public string TermofLoan { get; set; }
    public string Premium { get; set; }
    public DateTime? EffectDate { get; set; }
    public string Modeofpayment { get; set; } = string.Empty;
    public string? Rider { get; set; } = string.Empty;
    public DateTime? TerminationDate { get; set; }
    public string? FullNamedBeneficiaries { get; set; } = string.Empty;
    public string? AgeofBeneficiaries { get; set; } = string.Empty;
    public string? RelationshiptoInsured { get; set; } = string.Empty;
    public DateTime? Date { get; set; } = DateTime.Now;
}
