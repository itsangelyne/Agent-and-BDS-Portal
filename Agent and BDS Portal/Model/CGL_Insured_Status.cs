using System.ComponentModel.DataAnnotations;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Insured_Status
    {
            [Key]
            public int ID_Status { get; set; }
            public int ID_Insured { get; set; }
        public string? Status { get; set; }
    }
}
