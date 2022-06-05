namespace NewsBlog.Users.Core.Models.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.Empty;
    }
}
