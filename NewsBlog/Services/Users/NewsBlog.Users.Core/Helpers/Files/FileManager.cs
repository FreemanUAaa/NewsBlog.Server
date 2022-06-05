using Microsoft.AspNetCore.Http;

namespace NewsBlog.Users.Core.Helpers.Files
{
    public static class FileManager
    {
        public static async Task DeleteFile(string path) => await Task.Run(() => File.Delete(path));

        public static async Task SaveFile(IFormFile file, string path)
        {
            using FileStream stream = new(path, FileMode.Create);
            await file.CopyToAsync(stream);
        }
    }
}
