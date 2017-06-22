﻿namespace Sod.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

}
