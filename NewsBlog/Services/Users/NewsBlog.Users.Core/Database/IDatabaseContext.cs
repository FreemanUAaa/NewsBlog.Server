using Microsoft.EntityFrameworkCore;
using NewsBlog.Users.Core.Models;

namespace NewsBlog.Users.Core.Database
{
    public interface IDatabaseContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Cover> Covers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
