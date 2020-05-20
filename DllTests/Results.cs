using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTests
{
    public class Results
    {
        public int Id { get; set; }
        public virtual Tests Tests { get; set; }
        public virtual Users Users { get; set; }
        public string Dt { get; set; }
        public string rating { get; set; }
    }
}
