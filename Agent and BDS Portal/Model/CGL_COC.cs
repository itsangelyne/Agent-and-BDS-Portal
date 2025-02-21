using System.ComponentModel.DataAnnotations;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_COC
    {
        [Key]
        public int ID_COC { get; set; }
        public int ID_Insured { get; set; }
        public string? COC_Status { get; set; }
    }
}
