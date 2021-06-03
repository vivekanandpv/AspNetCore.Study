using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Study.Models
{
    public class Monument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double EntryFee { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
    }
}
