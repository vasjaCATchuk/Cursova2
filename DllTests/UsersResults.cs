using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class UsersResults : DbContext
    {
        public UsersResults(string str) : base(str)
        {

        }
        public DbSet<Results> Results { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
