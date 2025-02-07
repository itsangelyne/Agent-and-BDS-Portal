using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


public class DatabaseService
{
    private readonly string _connectionString;
    private readonly IWebHostEnvironment _applicationContext;

    public DatabaseService(IWebHostEnvironment env, IConfiguration configuration)
    {
        _applicationContext = _applicationContext;
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<string> SaveImageToWwwRoot(int imageId)
    {
        byte[] imageData = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            var query = "SELECT ImageColumn FROM CBLIC WHERE ID_CB = @ID_CB";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_CB", imageId);
                var result = await command.ExecuteScalarAsync();
                imageData = result as byte[];
            }
        }

        if (imageData != null && imageData.Length > 0)
        {
            
            string imagesFolder = Path.Combine(_applicationContext.WebRootPath, "images");
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }

            // Generate unique filename
            string fileName = $"image_{imageId}.png";
            string filePath = Path.Combine(imagesFolder, fileName);

            // Save the image to wwwroot/images
            await File.WriteAllBytesAsync(filePath, imageData);

            // Return the relative path for display
            return $"/images/{fileName}";
        }

        return null;
    }
}
