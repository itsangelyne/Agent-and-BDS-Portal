using System.ComponentModel.DataAnnotations;

namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Beneficiary
    {
        [Key]
        public int ID_Beneficiaries { get; set; }
        public int ID_Insured { get; set; }
        public string Full_Name { get; set; }
        public int Age { get; set; }
        public string Relation_To_The_Insured { get; set; }
    }
}
