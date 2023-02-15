using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public virtual Person? Person { get; set; }
    }
}
