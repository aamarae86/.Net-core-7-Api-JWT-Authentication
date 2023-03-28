using ApiAuthentication.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiAuthentication.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

    }
}
