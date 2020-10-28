using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
    public class IndustryLocations
    {
        public int Id { get; set; }
        public int IndustryId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
    }
}
