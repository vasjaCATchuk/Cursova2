using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class UsersTests : DbContext
    {
        public UsersTests(string str) : base(str)
        {

        }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
