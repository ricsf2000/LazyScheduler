using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyScheduler
{
    public class Assignment
    {
        public string? Name { get; set; }
        public int Difficulty { get; set; }
        public DateTime Deadline { get; set; }
        public double timeAwarded { get; set; }
    }
}
