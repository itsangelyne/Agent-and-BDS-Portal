//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;

namespace Agent_and_BDS_Portal.Data
{
    public class ImageService
{
        private readonly ApplicationDbContext _applicationContext;

        public ImageService(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }

        public async Task<List<CGL_Image>> GetImagesAsync()
        {
            var images = await _applicationContext.CGL_Image.ToListAsync();
            return images;
        }

        public string ConvertToBase64(byte[] imageData)
    {
        return "data:image/png;base64," + Convert.ToBase64String(imageData);
    }
}





   
}
