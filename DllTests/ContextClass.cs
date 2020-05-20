using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class ContextClass : DbContext
    {
        public ContextClass(string connect)
           : base(connect)
        {
        }

        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<Results> Results { get; set; }
    }
}
