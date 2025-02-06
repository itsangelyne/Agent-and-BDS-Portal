using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class User
    {
        [Key]
        public int ID_Bank_Account_Info { get; set; }

        public string First_Name { get; set; }
        public string? Middle_Name { get; set; }

        public string Last_Name { get; set; }

        public DateTime Date_Of_Birth { get; set; }
        public int ID_Policy_Holder { get; set; }
        public string? User_Level { get; set; }

    }
}




