using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Image
    {
      
            public int Id { get; set; }
            public string Name { get; set; }
            public byte[] ImageData { get; set; }
        }
    }

