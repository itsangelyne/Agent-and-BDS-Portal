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
    public string Height { get; set; } = string.Empty;
    public string Weight { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public long? ContactNumber { get; set; }
    public string? EmailAddress { get; set; } = string.Empty;
    public int? Age { get; set; }
    public DateTime? DateofBirth { get; set; }
    public string PlaceofBirth { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public long? GovernmentIDNo { get; set; }
    public string SourceofFunds { get; set; } = string.Empty;
    public string NatureofSelfEmployment { get; set; } = string.Empty;
    public string AddressofEmployer { get; set; } = string.Empty;
    public string OccupationNLivelihood { get; set; } = string.Empty;
    public DateTime date { get; set; } = DateTime.Now;
    public long? AmountofInsurance { get; set; }
    public string TermofLoan { get; set; } = string.Empty;
    public string Premium { get; set; } = string.Empty;
    public DateTime? EffectDate { get; set; }
    public string Modeofpayment { get; set; } = string.Empty;
    public string? Rider { get; set; } = string.Empty;
    public DateTime? TerminationDate { get; set; }
    public string? FullNamedBeneficiaries { get; set; } = string.Empty;
    public string? AgeofBeneficiaries { get; set; } = string.Empty;
    public string? RelationshiptoInsured { get; set; } = string.Empty;
    public DateTime? Date { get; set; } = DateTime.Now;
}
