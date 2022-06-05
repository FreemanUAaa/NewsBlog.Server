using NewsBlog.Users.Core.Models.Base;

namespace NewsBlog.Users.Core.Models
{
    public class Cover : BaseEntity
    {
        public string FileName { get; set; } = string.Empty;

        public Guid UserId { get; set; } = Guid.Empty;
    }
}
