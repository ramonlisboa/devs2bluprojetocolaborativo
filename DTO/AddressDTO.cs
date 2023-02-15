using Register.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.DTO
{
    public class AddressDTO
    {
        public int id { get; set; }
        public int? personId { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string district { get; set; }
        public string street { get; set; }
        public string number { get; set; }

        public virtual PersonDTO? person { get; set; }

        public Address mapToEntity()
        {
            return new Address()
            {
                Id = id,
                PersonId = personId,
                PostalCode = postalCode,
                District = district,
                Street = street,
                Number = number
            };
        }
        public AddressDTO mapToDTO(Address address)
        {
            return new AddressDTO()
            {
                id = address.Id,
                personId = address.PersonId,
                postalCode = address.PostalCode,
                district = address.District,
                street = address.Street,
                number = address.Number
            };
        }
    }
}
