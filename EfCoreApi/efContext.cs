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

        public DbSet<TestDoc> TestDocs { get; set; }


    }

    public class TestDoc
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
