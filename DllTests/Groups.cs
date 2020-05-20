using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class Groups
    {
        public Groups()
        {
            Users = new List<Users>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
