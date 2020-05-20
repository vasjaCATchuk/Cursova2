using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class TestsResults : DbContext
    {
        public TestsResults(string str) : base(str)
        {

        }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Results> Results { get; set; }
    }
}
