namespace NewsBlog.Users.Core.Helpers.Files
{
    public static class FileExtensions
    {
        private static readonly List<string> coverAllowedExtension = new()
        {
            ".png",
            ".jpg",
            ".jpeg"
        };

        public static bool ValidateCoverExtension(string extension)
        {
            return coverAllowedExtension.Contains(extension);
        }
    }
}
