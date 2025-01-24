using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class Cgl_ProductionReport
    {
        [Key]
        public int Pid { get; set; }
        public int Region { get; set; }
        public int Province {  get; set; }
        public int BankCode { get; set; }
        public int BankName { get; set; }
        public int January { get; set; }
        public int February { get; set; }
        public int March { get; set; }
        public int April { get; set; }
        public int May { get; set; }
        public int June { get; set; }
        public int July { get; set; }
        public int August { get; set; }
        public int September { get; set; }
        public int October { get; set; }
        public int November { get; set; }
        public int December { get; set; }
        public int Total { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int EndMonth { get; set; }
    }
}
