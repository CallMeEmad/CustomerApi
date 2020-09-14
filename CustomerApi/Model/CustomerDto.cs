using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CustomerApi.Model
{
    public class CustomerDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string InternationalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
