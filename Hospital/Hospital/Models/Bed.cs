using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.Models
{
    public partial class Bed
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public long? MobileNo { get; set; }
        public DateTime? Dob { get; set; }
        public string Hlocation { get; set; }
        public DateTime? Doadmission { get; set; }
        public string Department { get; set; }
    }
}
