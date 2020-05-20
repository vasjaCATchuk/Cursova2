using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class GroupUsers:DbContext
    {
        public GroupUsers(string str) : base(str)
        {

        }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
