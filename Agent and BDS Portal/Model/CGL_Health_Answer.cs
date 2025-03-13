using System.ComponentModel.DataAnnotations;

namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Health_Answer
    {
        [Key]
        public int ID_Health_Answer { get; set; }
        public int ID_Health_Question { get; set; }
        public int ID_Insured { get; set; }
        public string? Answer { get; set; }
        public string? Input_Type { get; set; }
        public string? Remarks { get; set; }
    }
}
