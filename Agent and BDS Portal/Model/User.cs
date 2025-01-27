using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Middle { get; set; }

        public string Lastname { get; set; }

        public string userName { get; set; }
        public string passWord { get; set; }
        public string userType { get; set; }
        public string Status { get; set; }

       
        public string createdBy { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;

    }
}




