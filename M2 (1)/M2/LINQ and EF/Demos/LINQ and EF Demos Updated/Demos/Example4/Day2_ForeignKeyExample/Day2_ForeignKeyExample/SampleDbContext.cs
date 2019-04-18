using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ForeignKeyExample
{
    class SampleDBContext : DbContext
    {
        public SampleDBContext() : base("SampleConn") { }

        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
