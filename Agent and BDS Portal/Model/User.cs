using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class User
    {

        public int Id { get; set; }
        public int EmployeeNo { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public string userName { get; set; }
        public string passWord { get; set; }
        public string userType { get; set; }
        public string Status { get; set; }

        public DateTime date { get; set; } = DateTime.Now;
        public string createdBy { get; set; }

    }
}




