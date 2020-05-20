using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class Tests
    {
        public Tests()
        {
            Results = new List<Results>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public virtual Users Users { get; set; }
        public string Dt { get; set; }
        public string PassTime { get; set; }
        public virtual ICollection<Results> Results { get; set; }
    }
}
