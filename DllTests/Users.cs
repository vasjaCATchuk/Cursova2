using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class Users
    {
        public Users()
        {
            Tests = new List<Tests>();
            Results = new List<Results>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Groups Groups { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Tests> Tests { get; set; }
        public virtual ICollection<Results> Results { get; set; }
    }
}
