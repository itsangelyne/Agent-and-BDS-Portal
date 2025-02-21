using System.ComponentModel.DataAnnotations;

namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Substandard_Rating
    {
        [Key]
        public int ID_Substandard_Rating { get; set; }
        public int ID_Insured { get; set; }
        public string? Ilness_Name { get; set; }
        public string? Regular_Age { get; set; }
        public string? Overage { get; set; }
    }
}
