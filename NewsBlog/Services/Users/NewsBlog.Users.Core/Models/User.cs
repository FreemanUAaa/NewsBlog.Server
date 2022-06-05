using NewsBlog.Users.Core.Models.Base;

namespace NewsBlog.Users.Core.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
    }
}
