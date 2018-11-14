using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public Guid id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Email { get; set; }

    }

    public class CarDoc
    {
        public Guid id { get; set; } = new Guid();
        public string Make { get; set; }
        public string Model { get; set; }

    }

}
