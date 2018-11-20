using Microsoft.EntityFrameworkCore;
using System;

namespace EfCoreApi
{
    public class EfTestContext : DbContext
    {
        public EfTestContext(DbContextOptions<EfTestContext> options) : base(options)
        {
            
        }

        public DbSet<UserDoc> UserDocs { get; set; }
        public DbSet<CarDoc> CarDocs { get; set; }

    }

    public class UserDoc
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }

    public class CarDoc
    {
        public string id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }

}
