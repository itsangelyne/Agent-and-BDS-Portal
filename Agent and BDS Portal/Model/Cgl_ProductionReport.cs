using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Data
{
    public class Cgl_ProductionReport
    {
        [Key]
        public int Pid { get; set; }
        public string Region { get; set; }
        public string Province {  get; set; }
        public int BankCode { get; set; }
        public string DCHS { get; set; }
        public string BankName { get; set; }
        public decimal January { get; set; }
        public decimal February { get; set; }
        public decimal March { get; set; }
        public decimal April { get; set; }
        public decimal May { get; set; }
        public decimal June { get; set; }
        public decimal July { get; set; }
        public decimal August { get; set; }
        public decimal September { get; set; }
        public decimal October { get; set; }
        public decimal November { get; set; }
        public decimal December { get; set; }
        public decimal Total { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string EndMonth { get; set; }
    }
}
