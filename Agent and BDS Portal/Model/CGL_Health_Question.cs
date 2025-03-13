using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Health_Question
    {
        [Key]
        public int ID { get; set; }
        public double? NO { get; set; }
        public string? Question { get; set; }
        public string? InputType { get; set; }
        public string? Button { get; set; }
        public string? ButtonText { get; set; }
        public string? DropDown { get; set; }
        public string? Status { get; set; }

    }
}
