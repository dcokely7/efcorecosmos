using System;
using Microsoft.EntityFrameworkCore;

namespace cosmos
{
    class EfTestContext : DbContext
    {
        public DbSet<TestDoc> TestDocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmosSql(
              "CosmosInstanceUrlHere",
              "PrimaryKeyGoesHere",
              "DatabaseName");
        }

    }

    public class TestDoc
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }

}

