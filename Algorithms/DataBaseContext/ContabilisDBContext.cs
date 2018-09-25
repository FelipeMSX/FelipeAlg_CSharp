using System;
using System.Data.Entity;

namespace DataBaseContext
{
    public class ContabilisDBContext : DbContext
    {
        public ContabilisDBContext() : base("connectionString")
        {

        }

        public DbSet<>
    }
}
